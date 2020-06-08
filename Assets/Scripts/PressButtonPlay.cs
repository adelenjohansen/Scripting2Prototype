using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButtonPlay : MonoBehaviour
{
    public AudioSource myAudio;
    public bool startedPlaying;
    public bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        startedPlaying = false;
        isPaused = false;
    }

    public void RecordPlayer()
    {

        if (!startedPlaying)
        {
            myAudio.Play();
            startedPlaying = true;
        }
        else
        {
            if (!isPaused)
            {
                myAudio.Pause();
                isPaused = true;
            }
            else
            {
                myAudio.UnPause();
                isPaused = false;
            }
        }



    }



    // Update is called once per frame
    void Update()
    {

    }
}
