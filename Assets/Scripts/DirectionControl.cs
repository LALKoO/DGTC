using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionControl : MonoBehaviour
{
    public float rotationSpeed = 6.5f; // скорость вращения
    Vector3 startPosition; // Vector3 начала координат
    Transform cube; // private переменная для хранения ссылки на Transform объекта
 

    void Start()
    {
        cube = gameObject.GetComponent<Transform>(); // получаем ссылку на компонент Trnasform
        startPosition = cube.position; // запоминаем стартовые координаты
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            cube.transform.Rotate(0, 90, 0);
        else if (Input.GetKeyDown(KeyCode.E))
            cube.transform.Rotate(0, -90, 0);

        //cube.Rotate(Vector3.up * rotationSpeed * Time.deltaTime); // вращаем 
        //cube.Rotate(cube.position + Vector3.up * moveX * rotationSpeed * Time.deltaTime);

    }
}