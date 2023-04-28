using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedGame : MonoBehaviour
{
    public GameObject pauseScreen;

    public void Pause()
    {
        Time.timeScale = 0; // Freeze every object to current position.
        pauseScreen.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1; // Unfreeze every object.
        pauseScreen.SetActive(false);
    }

    private void Update()
    {
        // Reset level if R key is pressed.
        if (Input.GetKeyUp(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
