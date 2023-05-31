using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    public static AudioManager sharedInstance;

    private AudioSource audioSource;

    public AudioClip coinClip;

    public AudioClip heartClip;

    public AudioClip enemyDeathClip;

    void Start()
    {
        if(sharedInstance!= null)
        {
            Destroy(gameObject);
        }
        sharedInstance = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayCoinSound()
    {
        audioSource.PlayOneShot(coinClip);
    }

    public void PlayHeartSound()
    {
        audioSource.PlayOneShot(heartClip);
    }

    public void PlayEnemyDeathSound()
    {
        audioSource.PlayOneShot(enemyDeathClip);
    }
}
