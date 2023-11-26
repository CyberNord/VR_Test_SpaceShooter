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
   [SerializeField] private Transform laserBeamOrigin;


   private AudioSource LaserAudioSource;
   private RaycastHit hit; 

   private void Awake()
   {
      LaserAudioSource = GetComponent<AudioSource>(); 
   }

   public void LaserGunFired()
   {
      laserAnimator.SetTrigger(Constants.Fire_Animation);
      LaserAudioSource.PlayOneShot(laserSFX);
      
      // Raycast
      if (Physics.Raycast(laserBeamOrigin.position, laserBeamOrigin.forward, out hit, 1500))
      {
         if (hit.transform.GetComponent<AsteroidHit>() != null)
         {
            hit.transform.GetComponent<AsteroidHit>().AsteroidDestroyed();
         }
         
      } 

   }
}
