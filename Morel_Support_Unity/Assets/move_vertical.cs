using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_vertical : MonoBehaviour
{
	public float moveSpeed = 15f;

	// Update is called once per frame
	void Update()
    {
		transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed) ;
	}



}
