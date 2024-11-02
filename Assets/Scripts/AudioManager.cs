using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip shootSound;
    public AudioClip enemyDeath; 


    void Start(){
        audioSource = gameObject.GetComponent<AudioSource>();
    }
    public void PlayShootSound(){
        audioSource.PlayOneShot(shootSound);
    }
    public void PlayEnemyDeathSound(){
        audioSource.PlayOneShot(enemyDeath);
    }
}
