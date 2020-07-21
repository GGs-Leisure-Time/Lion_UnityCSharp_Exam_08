using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public Runner runner;
    private AudioSource aud;

    void Start()
    {
        runner.arrive += EndSound ;
    }

    private void EndSound()
    {
        aud = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<AudioSource>();
        aud.Play(); 
    }
}
