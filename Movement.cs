using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public int poder;
    public GameObject[] enemigos;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update() {

        float translation = Input.GetAxis("Vertical") * movementSpeed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
    

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);

        transform.Rotate(0, rotation, 0);

    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "B") {
            enemigos = GameObject.FindGameObjectsWithTag("B");
            EventManager.OnColl += TurnColor;
        }
        
    }

    private void OnCollisionStay(Collision other) {
        if (other.gameObject.tag == "B") {
            enemigos = GameObject.FindGameObjectsWithTag("B");
            EventManager.OnColl -= TurnColor;
        }
        
    }
    void TurnColor() {
        foreach (GameObject enemigo in enemigos) {
            Color newColor = new Color( Random.value, Random.value, Random.value, 1.0f );
            enemigo.transform.GetComponent<Renderer>().material.color = newColor;
            poder -= 5;
        }
    }
}
