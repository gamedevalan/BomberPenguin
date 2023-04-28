using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shark : MonoBehaviour
{
    public ParticleSystem playerExplode;
    public ParticleSystem bombExplode;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bomb")
        {
            Instantiate(bombExplode, new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z), Quaternion.identity);
            SoundEffects.BombExplodeSound();
            Destroy(collision.gameObject);
            SharkManager.DecreaseHearts();
        }

        if (collision.tag == "Player")
        {
            Instantiate(playerExplode, new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z), Quaternion.identity);
            SoundEffects.BombExplodeSound();
            SharkManager.playerAlive = false;
            collision.gameObject.SetActive(false);
            Invoke("Restart", 1.5f);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
