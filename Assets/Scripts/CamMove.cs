using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour {
    public int a = 1;
    public GameObject player;

	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            a++;
            transform.Rotate(0, 90, 0);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            a--;
            transform.Rotate(0, -90, 0);
        }

        if( a == 1 || a == 5)
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10f);
        else if (a == 2)
            transform.position = new Vector3(player.transform.position.x, 10f, player.transform.position.z);
        else if (a == 3)
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 10f);
        else if (a == 4 || a == 0)
            transform.position = new Vector3(player.transform.position.x, -10f, player.transform.position.z);

        if (a == 0)
            a = 4;
        else if (a == 5)
            a = 1;
        
        

    }
}
