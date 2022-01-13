using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonStuff : MonoBehaviour
{
    private bool paused;

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void LevelSelection()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level Select");
    }
}
