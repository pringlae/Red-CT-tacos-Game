using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCat : MonoBehaviour
{
    [SerializeField] public float speed = 0; // скорость

    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime, Space.Self); // вращение планеты
    }
}
