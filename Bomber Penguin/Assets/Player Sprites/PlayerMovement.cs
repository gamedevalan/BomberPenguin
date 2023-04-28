using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private float movemenSpeed;
    public Animator animator;
    private bool isRunning;
    private float move = 0;

    private float leftOrRight;
    private bool facingRight;
    private bool canMove;

    public GameObject bomb;
    public Transform bombPlacer;

    // Start is called before the first frame update
    void Start()
    {
        movemenSpeed = 5;
        canMove = true;
        facingRight = true;
        isRunning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -20)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (!isRunning)
        {
            if (BombAmount.currentBombs > 0)
            {
                // PLACE BOMB
                if (CanPlace.canPlaceBomb && (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow)))
                {
                    animator.SetTrigger("Bomb_Put");
                    SoundEffects.PlaceBombSound();
                    BombAmount.BombUsed();
                    canMove = false;
                    StartCoroutine(BombCreation(.6f));
                }
            }

            // BLOW UP BOMB
            if (Input.GetKeyUp(KeyCode.Space))
            {
                animator.SetTrigger("Explode_Bomb");
            }
        }

        IEnumerator BombCreation(float timing)
        {
            // CREATE BOMB
            yield return new WaitForSeconds(.2f);
            Instantiate(bomb, bombPlacer.position, bombPlacer.rotation);

            // CAN'T MOVE AFTER CREATING BOMB
            yield return new WaitForSeconds(timing-.2f);
            canMove = true;
        }

            // MOVEMENT
        if (canMove)
        {
            animator.SetFloat("Speed", move);
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.right * movemenSpeed * Time.deltaTime);
                isRunning = true;
                leftOrRight = 1;
            }
            else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.right * movemenSpeed * Time.deltaTime);
                isRunning = true;
                leftOrRight = -1;
            }
            else
            {
                isRunning = false;
            }
        }

        // CHANGE DIRECTION
        if (leftOrRight > 0 && !facingRight)
        {
            facingRight = !facingRight;
            transform.Rotate(0, 180, 0);
        }

        else if (leftOrRight < 0 && facingRight)
        {
            facingRight = !facingRight;
            transform.Rotate(0, 180, 0);
        }

        // RUN ANIMATION
        if (isRunning)
        {
            move = 1f;
        }
        else
        {
            move = 0f;
        }
    }

}
