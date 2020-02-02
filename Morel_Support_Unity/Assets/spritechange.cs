using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spritechange : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite Idle;
    public Sprite Run;



    void Update()

    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.GetComponent<SpriteRenderer>().sprite = Idle)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Run;
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.GetComponent<SpriteRenderer>().sprite = Idle)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Run;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (this.gameObject.GetComponent<SpriteRenderer>().sprite = Idle)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Run;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (this.gameObject.GetComponent<SpriteRenderer>().sprite = Idle)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Run;
            }
        }


    }

}