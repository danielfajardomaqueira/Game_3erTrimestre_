using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIA : MonoBehaviour
{

    public float alertRange;
    public LayerMask playerMask;
    public float enemySpeed;
    bool beAlert;

    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        beAlert = Physics.CheckSphere(transform.position, alertRange, playerMask);

        if (beAlert == true)
        {
            Vector3 posPlayer = new Vector3(player.position.x, transform.position.y, player.position.z);
            //transform.LookAt(player);
            transform.LookAt(posPlayer);
            transform.position = Vector3.MoveTowards(transform.position, posPlayer, enemySpeed * Time.deltaTime);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, alertRange);
    }
}
