using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanPlace : MonoBehaviour
{
    public static bool canPlaceBomb;

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
