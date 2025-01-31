using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTest : MonoBehaviour
{
    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource sound;
    public bool alreadyPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!alreadyPlayed)
        {
            sound.PlayOneShot(SoundToPlay, Volume);
            alreadyPlayed = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!alreadyPlayed && Bell.inBell == true)
        {
            sound.PlayOneShot(SoundToPlay, Volume);
            //alreadyPlayed = true;
        }
    }
}
