using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Animator animate;
    public GameObject penguin;

    public GameObject winScreen;

    private void Start()
    {
        winScreen.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            animate.SetTrigger("Close"); // animation that changes a open door sprite to closed.
            penguin.SetActive(false);
            LevelDone();
        }
    }

    public void LevelDone()
    {
        winScreen.SetActive(true);
    }
}
