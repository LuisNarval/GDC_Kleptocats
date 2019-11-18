using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class personajeanimacion : MonoBehaviour
{

    public GameObject p1;
    public GameObject p2;
    public float cambio;

    // Start is called before the first frame update
    void Start()
    {
        p1.SetActive(true);
        p2.SetActive(false);
        cambio = 0.0f;
       
    }

    // Update is called once per frame
    void Update()
    {
        cambio = cambio + Time.deltaTime;

        if (cambio < 0.5f){
            p1.SetActive(true);
            p2.SetActive(false);

        }
            if (cambio >= 0.5f) {
            p1.SetActive(false);
            p2.SetActive(true);
        }
        if (cambio >= 0.9f) {
            cambio = 0.0f;
            cambio = cambio + Time.deltaTime;
        }
        


    }
}
