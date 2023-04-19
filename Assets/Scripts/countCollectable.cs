using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countCollectable : MonoBehaviour
{

    public int collectableOne = 0;
    public int collectableTwo = 0;

    private void OnTriggerEnter(Collider other)
    {
      if (other.CompareTag("collectableOne"))
        {
            Destroy(other.gameObject);
            collectableOne++;
        }

      if (other.CompareTag("collectableTwo"))
        {
            Destroy(other.gameObject);
            collectableTwo++;
        }
    }


}
