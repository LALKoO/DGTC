using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontRotation : MonoBehaviour
{
    public float rotationSpeed = 6.5f, range = 10f; // скорость вращения, скорость перемещения, допустимый размах для передвижения
    Vector3 startPosition; // Vector3 начала координат
    Transform cube; // private переменная для хранения ссылки на Transform объекта


    void Start()
    {
        cube = gameObject.GetComponent<Transform>(); // получаем ссылку на компонент Trnasform
        startPosition = cube.position; // запоминаем стартовые координаты
    }

    void Update()
    {
        cube.Rotate(Vector3.up * rotationSpeed * Time.deltaTime); // вращаем 
    }
}
