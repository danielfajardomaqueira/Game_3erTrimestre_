using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoDamage : MonoBehaviour
{

    public float countDamage;

    private BloodEffect bloodEffect;
    // Start is called before the first frame update
    void Start()
    {
        bloodEffect = FindObjectOfType<BloodEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && other.GetComponent<barraVida>())
        {
            other.GetComponent<barraVida>().TakingDamage(countDamage);
            StartCoroutine(bloodEffect.Blood()); 
        }
    }

    
}
