 using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    private float detectionRange;
    private bool closeEnough;

    private Rigidbody myRB;
    public float moveSpeed;

    //public PlayerController player;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();

        //player = FindObjectOfType<PlayerController>();

        closeEnough = false;
        detectionRange = 12f;
    }

    void FixedUpdate()
    {

        if( Vector3.Distance( player.position, transform.position) <= detectionRange )
        {
            closeEnough = true;
        }

        if(closeEnough == true)
        {
            myRB.velocity = (transform.forward * moveSpeed);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position);
    }
}
