using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour
{
    public SpriteRenderer redButton;
    public Sprite unPressedButton;
    public Sprite pressedButton;

    public double upLimit;
    public double downLimit;
    public double rightLimit;
    public double leftLimit;
    public float speed;
    public string direction;
    public int directionNum;

    private int pressedNum;

    private int oppDirectionNum;

    private bool[] arr = new bool[3];

    public GameObject platform;

    private void Start()
    {
        pressedNum = directionNum;
        oppDirectionNum = -1 * directionNum;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        redButton.sprite = pressedButton;
        pressedNum = oppDirectionNum;
        SoundEffects.ButtonSound();
        if (collision.tag == "Player")
        {
            arr[0] = true;
        }
        if (collision.tag == "Bomb")
        {
            arr[1] = true;
        }
        if (collision.tag == "WoodCrate")
        {
            arr[2] = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            arr[0] = false;
        }
        if (collision.tag == "Bomb")
        {
            arr[1] = false;
        }
        if (collision.tag == "WoodCrate")
        {
            arr[2] = false;
        }
        if (!SomethingIsPressing())
        {
            redButton.sprite = unPressedButton;
            pressedNum = directionNum;
            SoundEffects.ButtonSound();
        }
    }

    private bool SomethingIsPressing()
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i])
            {
                return true;
            }
        }
        return false;
    }

    private void Update()
    {
        if (direction.Equals("Horizontal"))
        {
            MovePlatform(pressedNum);
        }

        else if (direction.Equals("Vertical"))
        {
            MovePlatform(pressedNum);
        }
    }

    public void MovePlatform(int num)
    {
        switch (num)
        {
            case 1:
                if (platform.transform.position.x < rightLimit)
                {
                    platform.transform.Translate(Vector3.right * speed * Time.deltaTime);
                }
                break;
            case -1:
                if (platform.transform.position.x > leftLimit)
                {
                    platform.transform.Translate(Vector3.left * speed * Time.deltaTime);
                }
                break;
            case 2:
                if (platform.transform.position.y < upLimit)
                {
                    platform.transform.Translate(Vector3.up * speed * Time.deltaTime);
                }
                break;
            case -2:
                if (platform.transform.position.y > downLimit)
                {
                    platform.transform.Translate(Vector3.down * speed * Time.deltaTime);
                }
                break;
        }
    }
}
