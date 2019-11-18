using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickpersonaje : MonoBehaviour
{
    public GameObject papiroboton;
    // Use this for initialization
    void Start()
    {
        papiroboton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {

                //Select Stage
                if (hit.transform.name == "Cube")
                {
                    if (papiroboton.activeSelf == false)
                    {
                        Debug.Log("activo");
                        papiroboton.SetActive(true);
                    }
                    else
                    {
                        Debug.Log("desactivado");
                        papiroboton.SetActive(false);
                    }
                }
            }
        }
    }
}
