using UnityEngine;
using System.Collections;

public class CustomGravity : MonoBehaviour
{

    public Transform Sphere;
    public Transform player;
    public float gravity = 9.81f;

    void FixedUpdate()
    {
        Vector3 dir = (player.position - Sphere.position).normalized;
        Physics.gravity = dir * gravity;
    }
}
