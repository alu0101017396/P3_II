using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoqueDebug : MonoBehaviour
{
    public GameObject player;
    public GameObject[] objetosB;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {
            float angle = 10;

            if (Vector3.Angle(player.transform.forward, transform.position - player.transform.position) < angle) {
                EventManager.OnColl += disparado;
            }
        } 
    }
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            objetosB = GameObject.FindGameObjectsWithTag("B");
            foreach (GameObject obj in objetosB) {
                obj.GetComponent<Contador>().sumarContador();
             }
        }
    }

   public void mostrarChoque() {
        Debug.Log("El jugador choco con B");
    }

    void disparado() {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (distance > 2.0f) {
            Vector3 direction;
            direction = new Vector3(
                (transform.position.x - player.gameObject.transform.position.x),
                (transform.position.y - player.gameObject.transform.position.y),
                (transform.position.z - player.gameObject.transform.position.z));
            gameObject.GetComponent<Rigidbody>().AddForce(direction * 10.0f);
        } else {
            Destroy(gameObject);
        }
        EventManager.OnColl -= disparado;
    }
}
