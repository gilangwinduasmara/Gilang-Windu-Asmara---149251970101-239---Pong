using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public int maxPowerUpAmount;

    public Transform spawnArea;

    public Vector2 powerUpAreaMin;
    public Vector2 powerUpAreaMax;
    public int spawnInterval;

    private float _timeSinceLastSpawn;
    private List<GameObject> _powerUps;
    public List<GameObject> powerUpTemplates;

    // Start is called before the first frame update
    void Start()
    {
        _powerUps = new List<GameObject>();

        _timeSinceLastSpawn = 0;
    }

    void Update()
    {
        _timeSinceLastSpawn += Time.deltaTime;

        if (_timeSinceLastSpawn > spawnInterval)
        {
            _timeSinceLastSpawn -= spawnInterval;
            SpawnRandomPowerUp();
        }
    }

    public void SpawnRandomPowerUp(){
        SpawnRandomPowerUp(new Vector2(Random.Range(powerUpAreaMin.x, powerUpAreaMax.x), Random.Range(powerUpAreaMin.y, powerUpAreaMax.y)));
    }


    public void SpawnRandomPowerUp(Vector2 position)
    {
        if (_powerUps.Count >= maxPowerUpAmount)
        {
            return;
        }
        // simplify this
        if (position.x < powerUpAreaMin.x ||
            position.x > powerUpAreaMax.x ||
            position.y < powerUpAreaMin.y ||
            position.y > powerUpAreaMax.y)
        {
            return;
        }

        int randomIndex = Random.Range(0, powerUpTemplates.Count);

        GameObject powerUp = Instantiate(powerUpTemplates[randomIndex], new Vector3(position.x, position.y, powerUpTemplates[randomIndex].transform.position.z), Quaternion.identity, spawnArea);
        powerUp.SetActive(true);

        _powerUps.Add(powerUp);

    }

    public void RemovePowerUp(GameObject powerUp)
    {
        _powerUps.Remove(powerUp);
        Destroy(powerUp);
    }

    public void RemoveAllPowerUps()
    {
        foreach (GameObject powerUp in _powerUps)
        {
            Destroy(powerUp);
        }
        _powerUps.Clear();
    }
}
