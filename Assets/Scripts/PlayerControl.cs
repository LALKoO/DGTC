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
        /*
        speed = 1f;
        if (Input.GetKey(KeyCode.LeftShift))
            speed = 6f;

        if (Input.GetKeyDown(KeyCode.Q))
            a = 1;
        else if (Input.GetKeyDown(KeyCode.E))
            a = 0;


        if (a == 0)
        {
            float moveY = Input.GetAxis("Horizontal");
           rb.MovePosition(rb.position + Vector3.forward * moveY * speed * Time.deltaTime);
        }
        else
        {
            float moveX = Input.GetAxis("Horizontal");
            rb.MovePosition(rb.position + Vector3.right * moveX * speed * Time.deltaTime);
        }
        */
        //if (Input.GetKeyDown(KeyCode.E))
        //rb.transform.Rotate(0, 90, 0);
        //else if (Input.GetKeyDown(KeyCode.E))
        //rb.transform.Rotate(0, -90, 0);


        if (Input.GetKeyDown(KeyCode.Q))
        {
            a--;
            transform.Rotate(0, 90, 0);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            a++;
            transform.Rotate(0, -90, 0);
        }

        if (a == 1 || a == 5)
        {
            float moveX = Input.GetAxis("Horizontal");
            rb.MovePosition(rb.position + Vector3.right * moveX * speed * Time.deltaTime);
        }
        else if (a == 2)
        {
            float moveX = Input.GetAxis("Horizontal");
            rb.MovePosition(rb.position + Vector3.forward * moveX * speed * Time.deltaTime);
        }
        else if (a == 3)
        {
            float moveX = Input.GetAxis("Horizontal");
            rb.MovePosition(rb.position + Vector3.left * moveX * speed * Time.deltaTime);
        }
        else if (a == 4 || a == 0)
        {
            float moveX = Input.GetAxis("Horizontal");
            rb.MovePosition(rb.position + Vector3.back * moveX * speed * Time.deltaTime);
        }

        if (a == 0)
            a = 4;
        else if (a == 5)
            a = 1;

        if (Input.GetKeyDown(KeyCode.Space))
                rb.AddForce(Vector3.up * 200); 
          
	}
}
