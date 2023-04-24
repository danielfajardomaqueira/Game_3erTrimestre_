using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpHit : MonoBehaviour
{

    public float bounce;
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            rb.velocity = new Vector3(rb.velocity.x, bounce, rb.velocity.z);
            //Debug.Log($"mata");
        }
    }
}
