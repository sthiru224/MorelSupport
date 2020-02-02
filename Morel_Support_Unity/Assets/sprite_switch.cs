using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprite_switch : MonoBehaviour
{
	public Sprite Run = Mushroom;

    
    // Update is called once per frame
    void Update()

    {
		if (Input.GetKey(KeyCode.LeftArrow))
		{

			this.gameObject.GetComponent<SpriteRenderer>().sprite == Run;
			
		}
		

	}
}
