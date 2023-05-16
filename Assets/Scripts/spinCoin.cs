using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinCoin : MonoBehaviour
{
    private int speedRot = 140;

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
        transform.Rotate(Vector3.back, speedRot * Time.deltaTime);
    }
}
