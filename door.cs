﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (EventManager.keyCount >= 1) {
            Vector3 direction;
            direction = new Vector3(-1, 0, 0);
            gameObject.GetComponent<Rigidbody>().AddForce(direction * 2.0f, ForceMode.Impulse);
            EventManager.keyCount--;
        } else {
            
        }
    }
}
