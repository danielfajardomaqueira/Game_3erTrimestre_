using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public ParticleSystem oneParticle;
    public AudioClip[] teleportSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public Transform Target;
    public GameObject thePlayer;

    private void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.position = Target.transform.position;
        //thePlayer.transform.LookAt( Target.transform.forward);
        float yAngle = Target.transform.rotation.eulerAngles.y - thePlayer.transform.rotation.eulerAngles.y;
        thePlayer.transform.Rotate(0, yAngle, 0);
        oneParticle.Play();
    }

}
