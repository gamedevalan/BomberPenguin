using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float rightLimit;
    public float leftLimit;
    public float speed;
    public int directionNum;

    public int direction;

    // Platform directions are set in Inspector to go desired position.
    void Update()
    {
        if (directionNum == 0)
        {
            if (transform.position.x > rightLimit)
            {
                direction = -1;
            }
            else if (transform.position.x < leftLimit)
            {
                direction = 1;
            }
            transform.Translate(Vector3.right * direction * speed * Time.deltaTime);
        }


        if (directionNum == 1)
        {
            if (transform.position.x > rightLimit)
            {
                direction = 1;
            }
            else if (transform.position.x < leftLimit)
            {
                direction = -1;
            }
            transform.Translate(Vector3.left * direction * speed * Time.deltaTime);
        }


        if (directionNum == 2)
        {
            if (transform.position.y > rightLimit)
            {
                direction = -1;
            }
            else if (transform.position.y < leftLimit)
            {
                direction = 1;
            }
            transform.Translate(Vector3.up * direction * speed * Time.deltaTime);
        }


        if (directionNum == 3)
        {
            if (transform.position.y > rightLimit)
            {
                direction = 1;
            }
            else if (transform.position.y < leftLimit)
            {
                direction = -1;
            }
            transform.Translate(Vector3.down * direction * speed * Time.deltaTime);
        }

    }
}
