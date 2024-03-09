using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    private AudioSource _winSound;

    private void Start()
    {
        _winSound = gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {       
            BallController ballController = other.GetComponent<BallController>();

            if (ballController != null)
            {
                ballController.StartShrinking(); 
                _winSound.Play();
            }
        }
    }
}
