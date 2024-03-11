using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource soundFX, audioTheme;
    public AudioClip[] themeSongs;


    // Start is called before the first frame update
    void Start()
    {
        audioTheme.loop = true;

    }
}
