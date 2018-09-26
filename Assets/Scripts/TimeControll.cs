using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeControll : MonoBehaviour {

    private GameObject[] Objects;

    private Vector3[,] Positions;
    private Quaternion[,] Rotations;

    int Index;
    int Scale = 1000;

	void Start ()
    {
        Objects = GameObject.FindGameObjectsWithTag("TimeControlled");

        Positions = new Vector3[Objects.Length, Scale];
        Rotations = new Quaternion[Objects.Length, Scale];

    }
	

	void Update ()
    {
        if (Index > Scale) Index = 0;
        if (Index < 0) Index = 0;

        if (Input.GetKey(KeyCode.R))
        {
            Time.timeScale = 0;
            for(int i = 0; i < Objects.Length; i++)
            {
                Objects[i].transform.position = Vector3.Lerp(Positions[i,Index], Objects[i].transform.position, Time.deltaTime);
                Objects[i].transform.rotation = Quaternion.Lerp(Rotations[i, Index], Objects[i].transform.rotation, Time.deltaTime);
            }
            Index -= 1;
        }
    }

    private void FixedUpdate()
    {
        for (int i = 0; i < Objects.Length; i++)
        {
            Positions[i, Index] = Objects[i].transform.position;
            Rotations[i, Index] = Objects[i].transform.rotation;
        }
    }
}
