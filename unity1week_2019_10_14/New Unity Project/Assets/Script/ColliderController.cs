﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
    
    public bool isCorrect = false;

    private bool isCheck = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("");
        if (other.gameObject.tag == "W_Point")
        {
            Debug.Log("hit");
            isCorrect = true;
        }
        else
        {
            isCorrect = false;
        }
    }
}
