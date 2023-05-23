using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinHeart : MonoBehaviour
{
    private int speedRot = 140;
    public float countHealth;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        coinSpin();
    }

    private void coinSpin()
    {
        transform.Rotate(Vector3.up, speedRot * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && other.GetComponent<barraVida>())
        {
            other.GetComponent<barraVida>().CountHealth(countHealth);
            
        }
    }
}
