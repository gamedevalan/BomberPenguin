using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusicLoad : MonoBehaviour
{
    public AudioClip newTrack;

    private BackgroundMusic theAM;

    private void Start()
    {
        theAM = FindObjectOfType<BackgroundMusic>();

        if (newTrack != null)
        {
            theAM = FindObjectOfType<BackgroundMusic>();
            theAM.ChangeMusic(newTrack);
        }
    }
}
