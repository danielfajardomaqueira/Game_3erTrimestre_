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

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponentInParent<Animator>();
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
            //anim.SetFloat("movimientos", 0.1667f);
            
            
            //transform.position += new Vector3(transform.position.x,  transform.position.y, verticalInput * speed * Time.deltaTime);

        }
        else
        {
            //Debug.Log($"pared");
        }


        //Salto

        Vector3 floor = transform.TransformDirection(Vector3.down); //Solo salta si esta tocando el suelo

        if(Physics.Raycast(transform.position, floor, 0.15f))
        {
            floorIsDetected = true;
            anim.SetFloat("movimientos", 0);
            
            //print("Toca Suelo");
        }
        else
        {
            floorIsDetected = false;
            anim.SetFloat("movimientos", 0.5f);
            //print("No Toca Suelo");

        }

        isJump = Input.GetButtonDown("Jump");

        if (isJump && floorIsDetected)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            anim.SetFloat("movimientos", 0.333f);

        }
        
    }
}
