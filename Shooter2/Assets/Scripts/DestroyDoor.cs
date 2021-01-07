using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDoor : MonoBehaviour
{

    private float detectionRange;
    private bool closeEnough;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        closeEnough = false;
        detectionRange = 3f;
    }

    // Update is called once per frame
    void Update()
    {

        
        if( Vector3.Distance( player.position, transform.position) <= detectionRange )
        {
            closeEnough = true;
        }

        if(closeEnough == true)
        {
            Destroy(gameObject);
        }
        
    }

    /*
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            //or gameObject.SetActive(false);
        }
    }
    */
    
}
