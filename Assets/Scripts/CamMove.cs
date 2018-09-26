using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour {

    public GameObject player;

	void Update () {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10f);
        /*
        if (Input.GetKeyDown(KeyCode.Q))
            transform.Rotate(0, 90, 0);
        else if (Input.GetKeyDown(KeyCode.E))
            transform.Rotate(0, -90, 0);
        */
    }
}
