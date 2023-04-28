using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour
{
    public ParticleSystem explode;
    private bool gone = false;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Explosion")
        {
            Instantiate(explode, transform.position, Quaternion.identity);
            gone = true;
        }
    }

    void Update()
    {
        if (gone)
        {
            Destroy(gameObject);
        }
    }
}
