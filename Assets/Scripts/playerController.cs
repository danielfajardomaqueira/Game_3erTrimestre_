using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    Rigidbody rb;

    public float rotSpeed = 100f;
    public float speed = 10f;
    public float turnSpeed = 350f;
    public float horizontalInput;
    private float verticalInput;
    public float horizontalMouse;

    bool floorIsDetected = false;
    bool isJump = false;
    public float jumpForce = 100f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //Input Horizontal

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        horizontalMouse = Input.GetAxis("Mouse X");

        //Movimiento hacia Adelante

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        //Movimiento Lateral

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);



        //Salto

        Vector3 floor = transform.TransformDirection(Vector3.down); //Solo salta si esta tocando el suelo

        if(Physics.Raycast(transform.position, floor, 0.55f))
        {
            floorIsDetected = true;
            print("Toca Suelo");
        }
        else
        {
            floorIsDetected = false;
            print("No Toca Suelo");
        }

        isJump = Input.GetButtonDown("Jump");

        if (isJump && floorIsDetected)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }
}
