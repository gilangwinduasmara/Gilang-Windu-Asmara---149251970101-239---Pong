using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class MainMenuController : MonoBehaviour
{
    public void PlayGame(){
        Debug.Log("Created by Gilang Windu Asmara - 149251970101-239");
        SceneManager.LoadScene("Game");
    }
}
