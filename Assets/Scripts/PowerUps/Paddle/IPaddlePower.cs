using UnityEngine;
public interface IPaddlePower
{
    // void OnPowerOut(GameObject gameObject);


    void Buff(GameObject paddle);

    void OnExpired();
}
