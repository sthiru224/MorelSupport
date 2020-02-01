using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_left : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
	public float moveSpeed = 3f;
	float velocityX;
	float velocityY;
    bool facingRight = true;

     
    // Start is called before the first frame update
    void Start()
    {
		rigidbody2d = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
		float horizontal = Input.GetAxis("Horizontal");

		HandleMovement();
    }

    void HandleMovement()
	{
		rigidbody2d.velocity = Vector2.left;
	}
}
