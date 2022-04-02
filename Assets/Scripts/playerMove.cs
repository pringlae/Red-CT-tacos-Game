using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float speed;
    public float defaultScaleX;

    private void Start()
    {
        defaultScaleX = transform.localScale.x;
    }

    private void FixedUpdate()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0f);

        Vector3 scale = transform.localScale;
        if(Input.GetAxis("Horizontal") < 0)
        {
            scale.x = defaultScaleX;
        }
        else
        {
            scale.x = -defaultScaleX;
        }
        transform.localScale = scale;
    }
   
}
