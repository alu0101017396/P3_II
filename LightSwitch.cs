using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject theLight;
    public bool onSwitch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (onSwitch) {
            theLight.active = false;
        } else {
            theLight.active = true;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (!onSwitch && other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E)) {
            onSwitch = true;
        } else if (onSwitch && other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E)) {
            onSwitch = false;
        }
    }
 
}
