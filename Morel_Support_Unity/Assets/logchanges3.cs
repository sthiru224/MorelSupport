using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class logchanges3 : MonoBehaviour
{
	// Start is called before the first frame update
	public Sprite Alive;
	public Sprite Dead;

	private bool Inside = false;



	private void OnTriggerEnter2D()
	{
		Debug.Log("HEY NUMBER 3");

		Inside = true;
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.F) && Inside == true)
		{
			Debug.Log("is workkk");
			if (this.gameObject.GetComponent<SpriteRenderer>().sprite = Alive)
			{
				this.gameObject.GetComponent<SpriteRenderer>().sprite = Dead;

			}
		}
	}
}

