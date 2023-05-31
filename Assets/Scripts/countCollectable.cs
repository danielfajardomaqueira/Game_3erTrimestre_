using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class countCollectable : MonoBehaviour
{

    public int collectableOne = 0;
    //private int maxCollectableOne = 17;
    public int collectableTwo = 0;

    public GameObject redInvisibleWall;
    public TMP_Text coinText;
    //public static CoinCounter instance;

    private void OnTriggerEnter(Collider other)
    {
      if (other.CompareTag("collectableOne"))
        {
            Destroy(other.gameObject);
            collectableOne++;
            coinText.text = "COINS:" + collectableOne.ToString();
            
        }

      if (other.CompareTag("collectableTwo"))
        {
            Destroy(other.gameObject);
            collectableTwo++;
        }
    }



    private void Start()
    {
        
    }

    private void Update()
    {
        if (collectableOne == 20)
        {
            Destroy(redInvisibleWall);
        }
    }

    private void Awake()
    {
       // instance = this;
    }
}
