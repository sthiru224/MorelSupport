using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_left : MonoBehaviour
{
    float moveSpeed;
    RigidBody2D rigidbody2d;


    // Start is called before the first frame update
    void Start()
    {
    rigidbody2d = GetComponent<RigidBody2D>();
    moveSpeed = 10f;   
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKey(KeyCode.A))

        rigidbody2d.velocity = transform.right * moveSpeed;
        
    }
    
    
}
