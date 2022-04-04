using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class error : MonoBehaviour
{
    public GameObject alarm;
    public GameObject grafic;
   
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
            this.spriteRenderer.enabled = true;
        }
        else
        {
            this.spriteRenderer.enabled = false;
        }

      
    }
}
