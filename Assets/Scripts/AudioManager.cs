using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    public static AudioManager sharedInstance;

    private AudioSource audioSource;

    public AudioClip coinClip;
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

}
