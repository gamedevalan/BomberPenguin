using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public int level;
    public void GoToLevel()
    {
        SceneManager.LoadScene("Level "+ level);
    }

    public void GoToBack()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Boss()
    {
        SceneManager.LoadScene("Level Boss Intro");
    }
}
