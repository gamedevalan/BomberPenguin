using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCoin : MonoBehaviour
{
    public static bool alreadyPresentBoss;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bomb" || collision.tag == "Player" || collision.tag == "WoodCrate")
        {
            BombAmount.PickUpCoin();
            SoundEffects.CoinPickupSound();
            alreadyPresentBoss = false;
            Destroy(gameObject);
        }
    }
}
