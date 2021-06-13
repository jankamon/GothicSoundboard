using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTheSound : MonoBehaviour
{
    public AudioSource sound;
    private bool isPlaying;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySound()
    {
        if (isPlaying)
        {
            sound.Stop();
            isPlaying = false;
        }
        else
        {
            sound.Play();
            isPlaying = true;
        }
    }
}