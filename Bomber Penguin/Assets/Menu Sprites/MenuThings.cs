using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuThings : MonoBehaviour
{
    public GameObject bomb;
    public GameObject credits;

    private void Start()
    {
        bomb.SetActive(false);
    }

    public void MoveBombIcon()
    {
        bomb.SetActive(true);
    }

    public void StopBombIcon()
    {
        if (bomb != null)
        {
            bomb.SetActive(false);
        }
    }

    public void DestroyBombIcon()
    {
        Destroy(bomb);
        bomb = null;
    }

    public void OpenCredits()
    {
        credits.SetActive(true);
    }

    public void CloseCredits()
    {
        credits.SetActive(false);
    }
}
