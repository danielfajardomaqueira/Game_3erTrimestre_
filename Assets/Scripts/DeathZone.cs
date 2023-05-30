using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    //public Teleport teleport;
    public Transform Target;
    public GameObject thePlayer;
    private void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.position = Target.transform.position;
        float yAngle = Target.transform.rotation.eulerAngles.y - thePlayer.transform.rotation.eulerAngles.y;
        thePlayer.transform.Rotate(0, yAngle, 0);
        //if (other.CompareTag("Player"))
        //{
        //Debug.Log("MORIR ES VIVIR");

        //TODO: enviar al teleport de la variable
        //}
    }
}
