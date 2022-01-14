using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanPlace : MonoBehaviour
{
    public static bool canPlaceBomb; // A collider that checks if the player is
                                     // too close to an object to place. Prevents a
                                     // bomb from being inside another object.

    private void Start()
    {
        canPlaceBomb = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Walls")
        {
            canPlaceBomb = false;
        }
        if (collision.tag == "WoodCrate")
        {
            canPlaceBomb = false;
        }
        if (collision.tag == "MetalBox")
        {
            canPlaceBomb = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Walls")
        {
            canPlaceBomb = true;
        }
        if (collision.tag == "WoodCrate")
        {
            canPlaceBomb = true;
        }
        if (collision.tag == "MetalBox")
        {
            canPlaceBomb = true;
        }
    }
}
