using System.Collections;
using System.Collections.Generic;
using System;

using UnityEngine;
using UnityEngine.UI;

public class RandSound : MonoBehaviour
{
    public AudioClip[] sounds;
    
    public void a()
    {

        AudioSource audio = GetComponent<AudioSource>();

        System.Random rand = new System.Random();
        int randT = rand.Next(0, 2);

        audio.clip = sounds[randT];
       
        audio.Play();
       
    }
    void Start()
    {

        AudioSource audio = GetComponent<AudioSource>();

        System.Random rand = new System.Random();
        int randT = rand.Next(0, 2);

        audio.clip = sounds[randT];

        //audio.Play();
    }
}
