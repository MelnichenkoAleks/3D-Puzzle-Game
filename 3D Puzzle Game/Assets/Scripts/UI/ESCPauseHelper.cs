using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESCPauseHelper : MonoBehaviour
{
    public GameObject pauseMenu; 

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }
    }

    private void TogglePauseMenu()
    {
        bool isMenuActive = pauseMenu.activeSelf; 

        
        pauseMenu.SetActive(!isMenuActive);
    }
}