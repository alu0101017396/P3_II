using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    public int cont;
    // Start is called before the first frame update
    void Start()
    {
        cont = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player")
            GameObject.FindGameObjectWithTag("A").GetComponent<ChoqueDebug>().mostrarChoque();
    }

    public void sumarContador() {
        cont++;
    }
}
