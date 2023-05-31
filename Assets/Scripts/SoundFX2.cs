using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX2 : MonoBehaviour
{
    private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager.sharedInstance.PlayHeartSound();
            Destroy(gameObject);
        }

    }
}
