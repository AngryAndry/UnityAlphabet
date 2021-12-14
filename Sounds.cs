using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource din;
   

    void Start()
    {
        din = GetComponent<AudioSource>();
    }
    public void DINDIN()
    {
        din.Play();
        
    }
    void Update()
    {
      
    }
}
