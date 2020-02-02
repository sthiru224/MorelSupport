using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_horizontal : MonoBehaviour
{
	public float moveSpeed = 15f;
	bool moving = false;
	private float t = 0.0f;

	private Rigidbody2D rBody;
    SpriteRenderer spriteRenderer;

	void Awake()
	{
		rBody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update()
  // Currently unable to stop movement once key pressed
    {
		if (Input.GetKey(KeyCode.LeftArrow))  
        {
            rBody.velocity = new Vector2(-1.0f, 0.0f);
            moving = true;
            t = 0.0f;
            spriteRenderer.sprite = Resources.Load<Sprite>("Mushroom Friend Run");
        }
    if (Input.GetKey(KeyCode.A))
        {
            rBody.velocity = new Vector2(-1.0f, 0.0f);
            moving = true;
            t = 0.0f;
            spriteRenderer.sprite = Resources.Load<Sprite>("Mushroom Friend Run");
            
        }
    if (Input.GetKey(KeyCode.RightArrow))
        {
            rBody.velocity = new Vector2(1.0f, 0.0f);
            moving = true;
            t = 0.0f;
            
        }
    if (Input.GetKey(KeyCode.D))
        {
            rBody.velocity = new Vector2(1.0f, 0.0f);
            moving = true;
            t = 0.0f;
        }
    if (moving)
        {
            // Record the time spent moving up or down.
            // When this is 1sec then display info
            t = t + Time.deltaTime;
            if (t > 1.0f)
            {
                Debug.Log(gameObject.transform.position.y + " : " + t);
                t = 0.0f;
            }
        }
        
		//rBody.AddForce(Vector2.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
	}



}
