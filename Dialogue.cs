using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public Text textDisplay;
    public string[] sentences;
    public int index;
    public float typingSpeed;

    public GameObject nextButton;

    public GameObject[] currSprite;
    private GameObject shownSprite;
    private int spriteIndex;

    public string[] charcters;
    public Text whosTalking;

    public Animator animate;

    public int goToScene;

    private void Start()
    {
        textDisplay.text = "";
        ShowSprite();
        nextButton.SetActive(false);
        StartCoroutine(Type());    
    }

    private void Update()
    {
        // Only show next button once current paragraph finishes.
        if (textDisplay.text == sentences[index])
        {
            nextButton.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            // Type writer text display.
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    // Goes to the next character talking if applicable, if not, go to next scene.
    public void NextSentence()
    {
        nextButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            spriteIndex++;
            ShowSprite();
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            nextButton.SetActive(false);
            IntroNext();
        }
    }

    public void IntroNext()
    {
        animate.SetTrigger("FadeOut");
    }

    public void FadeDone()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SceneChanger()
    {
        SceneManager.LoadScene(goToScene);
    }

    private void ShowSprite()
    {
        // Changes which character is talking.
        shownSprite = currSprite[spriteIndex];
        currSprite[spriteIndex].SetActive(true);
        whosTalking.text = charcters[spriteIndex];
        for (int i = 0; i < currSprite.Length; i++)
        {
            if (shownSprite != currSprite[i])
            {
                currSprite[i].SetActive(false);
            }
        }
    }
}
