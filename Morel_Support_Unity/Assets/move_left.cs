using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_left : MonoBehaviour
{
     public Rigidbody rigidbody2d;
     public float moveSpeed;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKey(KeyCode.A))

        rigidbody2d.velocity = transform.left * moveSpeed;
    }
}
