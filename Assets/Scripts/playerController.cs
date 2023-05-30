using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    Rigidbody rb;

    public ParticleSystem oneParticle;

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

    [SerializeField]bool floorIsDetected = false;
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


            //transform.position += new Vector3(transform.position.x,  transform.position.y, verticalInput * speed * Time.deltaTime);

        }
        else
        {
            //Debug.Log($"pared");
        }


        //Salto

        Vector3 floor = transform.TransformDirection(Vector3.down); //Solo salta si esta tocando el suelo
        Color c = Color.red;
        if(Physics.Raycast(transform.position + 0.1f * Vector3.up, floor, 0.15f))
        {
            floorIsDetected = true;
            c = Color.green;
        }
        else
        {
            floorIsDetected = false;
        }
        Debug.DrawRay(transform.position + 0.1f * Vector3.up, Vector3.down * 0.15f, c);
        isJump = Input.GetButtonDown("Jump");

        if (isJump && floorIsDetected)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
        
    }



    private void LateUpdate()
    {
        Vector2 mov = new Vector2(horizontalInput, verticalInput);

        if(mov.magnitude < Mathf.Epsilon)
        {
            anim.SetBool("Run", false);
        }
        else
        {
            anim.SetBool("Run", true);
        }
        

        if (isJump && floorIsDetected)
        {
            anim.SetBool("Run", false);
            anim.SetBool("Jump1", true);
        }
        else
        {
            anim.SetBool("Jump1", false);

        }

        if (!floorIsDetected)
        {
            anim.SetBool("Run", false);
            anim.SetBool("Jump2", true);
        }
        else
        {
            anim.SetBool("Jump2", false);
        }
    }
}
