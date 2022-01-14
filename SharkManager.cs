using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SharkManager : MonoBehaviour
{
    public GameObject[] sharks; // Array of sharks that are active when called.
    private GameObject currSprite;
    public GameObject[] warning;
    private GameObject currWarning;
    private static int totalHealth = 5;
    private static int health;
    public GameObject[] setHearts;
    public static GameObject[] hearts;

    public static bool playerAlive;

    public Transform spawnerLeft;
    public Transform spawnerRight;
    public GameObject coin;

    public GameObject instructions;

    private void Start()
    {
        BombCoin.alreadyPresentBoss = false;
        hearts = setHearts;
        playerAlive = true;
        health = totalHealth;
        StartCoroutine(ChooseWhichShark(3f));
    }

    public void LookAtInstructions()
    {
        Time.timeScale = 0;
        instructions.SetActive(true);
    }

    public void CloseInstructions()
    {
        Time.timeScale = 1;
        instructions.SetActive(false);
    }

    IEnumerator ChooseWhichShark(float timing)
    {
        yield return new WaitForSeconds(timing);
        WhichShark();
    }

    IEnumerator ShowTheShark(float timing, int randNum)
    {
        yield return new WaitForSeconds(timing);
        RevealShark(randNum);
    }

    private void WhichShark()
    {
        for (int i = 0; i < sharks.Length; i++)
        {
            sharks[i].SetActive(false);      
        }
        // Randomly chooses a shark in the array.
        int randNum = Random.Range(0, 5);
        currWarning = warning[randNum];
        warning[randNum].SetActive(true);

        for (int i = 0; i < warning.Length; i++)
        {
            if (currWarning != warning[i])
            {
                warning[i].SetActive(false);
            }
        }
        StartCoroutine(ShowTheShark(2f, randNum));
    }

    private void RevealShark(int randNum)
    {
        currSprite = sharks[randNum];
        sharks[randNum].SetActive(true);
        BombCoinSpawn();
        StartCoroutine(ChooseWhichShark(2f));
    }

    // Shark has been hit, changes the amount of heart sprites.
    public static void DecreaseHearts()
    {
        health = health - 1;
        for (int i = 0; i < totalHealth; i++)
        {
            hearts[i].SetActive(false);
        }
        for(int i = 0; i < health; i++)
        {
            hearts[i].SetActive(true);
        }
    }

    private void BombCoinSpawn()
    {
        if (!BombCoin.alreadyPresentBoss) {
            int coinPos = Random.Range(0, 2);
            if (coinPos == 0)
            {
                Instantiate(coin, spawnerLeft.position, spawnerLeft.rotation);
            }
            else
            {
                Instantiate(coin, spawnerRight.position, spawnerRight.rotation);
            }
            BombCoin.alreadyPresentBoss = true;
        }
    }

    private void Update()
    {
        if (health == 0 && playerAlive)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
