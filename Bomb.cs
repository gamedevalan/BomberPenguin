using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject bomb;
    public GameObject damageRadius;
    public ParticleSystem explode;
    void Update()
    {
        // BLOW UP BOMB
        if (Input.GetKeyUp(KeyCode.Space))
        {
            SoundEffects.BombExplodeSound();
            Instantiate(explode, transform.position, Quaternion.identity);
            Instantiate(damageRadius, transform.position, Quaternion.identity);
            Destroy(bomb);
        }
    }


}
