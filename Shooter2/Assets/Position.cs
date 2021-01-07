using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    private Quaternion rotation;
    void Start ()
    {
        
    }

    void Update ()
    {
        transform.Rotate(Vector3.right * 0);
    }   
}
