using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{

    public float speed;
    Vector2 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float offset = Mathf.Repeat(Time.time * speed, 475);
        transform.position = startPosition + new Vector2(0, -offset);
    }
}
