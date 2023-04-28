using UnityEngine.UI;
using UnityEngine;
using System;

public class BombAmount : MonoBehaviour
{
    public int bombTotal;
    public static int currentBombs;
    public Text bombLeft;

    // Start is called before the first frame update
    void Start()
    {
        currentBombs = bombTotal;
    }

    // Update is called once per frame
    void Update()
    {
        bombLeft.text = "X " + currentBombs;
    }

    public static void BombUsed()
    {
        currentBombs--;
    }

    public static void PickUpCoin()
    {
        currentBombs = currentBombs + 1;
    }
}
