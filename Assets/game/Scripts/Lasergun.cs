using System;
using System.Collections;
using System.Collections.Generic;
using game.Scripts;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Lasergun : MonoBehaviour
{

   [SerializeField] private Animator laserAnimator; 
   [SerializeField] private AudioClip laserSFX;


   private AudioSource LaserAudioSource;

   private void Awake()
   {
      LaserAudioSource = GetComponent<AudioSource>(); 
   }

   public void LaserGunFired()
   {
      laserAnimator.SetTrigger(Constants.Fire_Animation);
      LaserAudioSource.PlayOneShot(laserSFX);
      
      // Raycast
      
      
   }
}
