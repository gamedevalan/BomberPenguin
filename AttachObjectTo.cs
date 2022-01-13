using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachObjectTo : MonoBehaviour
{

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

