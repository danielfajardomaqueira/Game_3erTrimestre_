using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRutine : MonoBehaviour
{

    public GameObject[] wayPoints;
    public float enemySpeed = 2f;
    private int wayPointsIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveEnemy();
    }

    private void moveEnemy()
    {
        if (Vector3.Distance(transform.position, wayPoints[wayPointsIndex].transform.position) < 0.1f)
        {
            wayPointsIndex++;

            if (wayPointsIndex >= wayPoints.Length) //Repite la posicion inicial al terminar el index, se genera un "bucle" para que la plataforma se mueva de un punto a otro
            {
                wayPointsIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, wayPoints[wayPointsIndex].transform.position, enemySpeed * Time.deltaTime);
    }
}
