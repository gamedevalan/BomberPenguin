using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachObjectTo : MonoBehaviour
{
    // Allows an object to "stick" to a moving object.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.parent = transform;
        }
        if (collision.gameObject.tag == "Bomb")
        {
            collision.transform.parent = transform;
        }

    }

    // If an object moves off a moving object through inputs or outside influence, will not move
    // with moving object anymore.
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.transform.parent = null;
        }
        if (collision.gameObject.tag == "Bomb")
        {
            collision.transform.parent = null;
        }
    }
}

