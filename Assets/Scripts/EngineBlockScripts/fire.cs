using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject alarm;
    public GameObject firer;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (alarm.activeInHierarchy)
        {
            this.spriteRenderer.enabled = false;
        }
        if(alarm.activeInHierarchy == false)
        {
            this.spriteRenderer.enabled = true;
        }
    }
}
