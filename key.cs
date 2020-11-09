using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        Debug.Log("ola");
        if (other.gameObject.tag == "Player") {
            EventManager.keyCount += 1;
            Destroy (gameObject);
        }
    }
}
