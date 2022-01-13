using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource placeBomb;
    public static AudioSource placeBombStatic;

    public AudioSource bombExplode;
    public static AudioSource bombExplodeStatic;

    public AudioSource coinPickup;
    public static AudioSource coinPickupStatic;

    public AudioSource button;
    public static AudioSource buttonStatic;

    private void Start()
    {
        placeBombStatic = placeBomb;
        bombExplodeStatic = bombExplode;
        coinPickupStatic = coinPickup;
        buttonStatic = button;
    }

    public static void PlaceBombSound()
    {
        placeBombStatic.Play();
    }

    public static void BombExplodeSound()
    {
        bombExplodeStatic.Play();
    }

    public static void CoinPickupSound()
    {
        coinPickupStatic.Play();
    }

    public static void ButtonSound()
    {
        buttonStatic.Play();
    }

    public AudioSource hover;
    public AudioClip hoverEffect;

    public void HoverSound()
    {
        hover.PlayOneShot(hoverEffect);
    }
}
