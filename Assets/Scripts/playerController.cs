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
    public LayerMask layerMask;

    public float playerHeight;
    public float playerRadius;
    public float moveDistance;

    bool floorIsDetected = false;
    bool isJump = false;
    //bool doubleJump = false;
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

        

        

        //Movimiento Lateral

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

        //Movimiento hacia Adelante
        //Colision con pared
        if (!Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight,
            playerRadius, transform.forward, speed*Time.deltaTime, layerMask))
        {
            
            transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        }
        else
        {
            //Debug.Log($"pared");
        }


        //Salto

        Vector3 floor = transform.TransformDirection(Vector3.down); //Solo salta si esta tocando el suelo

        if(Physics.Raycast(transform.position, floor, 0.55f))
        {
            floorIsDetected = true;
            
            //print("Toca Suelo");
        }
        else
        {
            floorIsDetected = false;
            //print("No Toca Suelo");
        }

        isJump = Input.GetButtonDown("Jump");

        if (isJump && floorIsDetected)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);


        }
        
    }
}
