using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_horizontal : MonoBehaviour
{ 

    // Update is called once per frame
    void Update()
    {
		transform.Translate(Input.GetAxis("Horizontal") *15f* Time.deltaTime, 0f, 0f);
    }

    
}
