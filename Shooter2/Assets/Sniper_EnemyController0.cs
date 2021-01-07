using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Sniper_EnemyController0 : MonoBehaviour
{
    private double computeDistrance2D(Vector2 coords1, Vector2 coords2)
    {
        return Math.Sqrt(Math.Pow((coords1.x - coords2.x), 2) + Math.Pow((coords1.y - coords2.y), 2));
    }


    private Rigidbody myRB;
    public float moveSpeed;
    private GameObject playerEntity;
    public PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        playerEntity = GameObject.Find("Player");
        player = FindObjectOfType<PlayerController>();
    }

    void FixedUpdate()
    {
        if(playerEntity.active == true)
        {
            Vector3 my_coords = transform.position;
            Vector3 target_coords = GameObject.Find("Player").transform.position;
            
            if(computeDistrance2D(new Vector2(my_coords.x, my_coords.y), new Vector2(target_coords.x, target_coords.y)) > 20)
            {
                myRB.velocity = (transform.forward * moveSpeed);
            }
            else
            {
                if(computeDistrance2D(new Vector2(my_coords.x, my_coords.y), new Vector2(target_coords.x, target_coords.y)) < 15)
                {
                    myRB.velocity = (transform.forward * -moveSpeed);
                }
                else
                {
                    myRB.velocity = (transform.forward * 0.0f);
                }
            }
        }
        else
        {
            /* Do nothing */
        }

    

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position);

    }
}
