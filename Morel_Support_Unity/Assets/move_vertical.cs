using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move_vertical : MonoBehaviour
{
	public float moveSpeed = 15f;
	bool moving = false;
	private float t = 0.0f;

	private Rigidbody2D rBody;

	void Awake()
	{
		rBody = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
    {
		if (Input.GetKey(KeyCode.UpArrow))
        {
            rBody.velocity = new Vector2(0.0f, 2.0f);
            moving = true;
            t = 0.0f;
        }
		//rBody.AddForce(Vector2.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
	}



}
