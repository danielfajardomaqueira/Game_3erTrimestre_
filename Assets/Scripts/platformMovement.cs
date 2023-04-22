using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement : MonoBehaviour
{
    public GameObject[] wayPoints;
    public float platformSpeed = 2f;
    private int wayPointsIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlatform();
    }

    void MovePlatform()
    {
        if (Vector3.Distance(transform.position, wayPoints[wayPointsIndex].transform.position) < 0.1f)
        {
            wayPointsIndex++;

            if (wayPointsIndex >= wayPoints.Length) //Repite la posicion inicial al terminar el index, se genera un "bucle" para que la plataforma se mueva de un punto a otro
            {
                wayPointsIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, wayPoints[wayPointsIndex].transform.position, platformSpeed*Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("MoveElement"))
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(null);
        }
    }

}
