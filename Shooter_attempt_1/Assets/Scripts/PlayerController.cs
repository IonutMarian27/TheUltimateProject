using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    private Rigidbody myRigidBody;

    private Vector3 moveInput;
    private Vector3 moveVelocity;

    public FixedJoystick leftStick;
    public FixedJoystick rightStick;

    // -- old way of detecting the joysticks
    //public GameObject lJoystick;
    //public GameObject rJoystick;

    public GunController theGun;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();


        // -- old way of detecting the joysticks

        //lJoystick = GameObject.FindWithTag("leftJoystick");
        //leftStick = lJoystick.GetComponent<FixedJoystick>();

        //rJoystick = GameObject.FindWithTag("rightJoystick");
        //rightStick = rJoystick.GetComponent<FixedJoystick>();

    }

    // Update is called once per frame
    void Update()
    {
        // moving with keys
        //moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));

        moveInput = new Vector3(leftStick.Horizontal, 0f, leftStick.Vertical);
        moveVelocity = moveInput * moveSpeed;

        //transform.LookAt(new Vector3(rightStick.Horizontal*150, transform.position.y, rightStick.Vertical*150));

        //frameMovement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        //Quaternion rotation = Quaternion.LookRotation(new Vector3(rightStick.Horizontal, transform.position.y, rightStick.Vertical));
        //transform.LookAt = rotation;

        if(Mathf.Abs(rightStick.Horizontal) >= 0.2f || Mathf.Abs(rightStick.Vertical) >= 0.2f)
        {
            float heading = Mathf.Atan2(rightStick.Horizontal, rightStick.Vertical);
            transform.rotation = Quaternion.Euler(0f, heading * Mathf.Rad2Deg, 0f);

            theGun.isFiring = true;

        } else
        {
            theGun.isFiring = false;
        }

        

    }

    void FixedUpdate()
    {
        myRigidBody.velocity = moveVelocity;
    }
}
