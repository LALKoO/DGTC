using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float speed = 1f;
    public int a = 1;
    private Rigidbody rb;


	void Start () {
        rb = GetComponent <Rigidbody> ();
	}

	void Update () {

        if (Input.GetKey(KeyCode.LeftShift))
            speed = 6f;

        if (Input.GetKeyDown(KeyCode.Q))
            a = 1;
        else if (Input.GetKeyDown(KeyCode.E))
            a = 0;


        if (a == 0)
        {
            float moveY = Input.GetAxis("Vertical");
           rb.MovePosition(rb.position + Vector3.right * moveY * speed * Time.deltaTime);
        }
        else
        {
            float moveX = Input.GetAxis("Horizontal");
            rb.MovePosition(rb.position + Vector3.right * moveX * speed * Time.deltaTime);
        }


        //rb.transform.Rotate(0, 90, 0);
        //else if (Input.GetKeyDown(KeyCode.E))
            //rb.transform.Rotate(0, -90, 0);

            if (Input.GetKeyDown(KeyCode.Space))
                rb.AddForce(Vector3.up * 200); 
          
	}
}
