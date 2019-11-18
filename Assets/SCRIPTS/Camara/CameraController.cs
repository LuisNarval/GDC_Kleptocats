using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour{

    [Header("Velocidad")]
    [Header("CONFIGURACION")]
    public float VelocidadX;
    public float VelocidadY;
    [Header("Límites")]
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    [Header("REFERENCIAS A ESCENA")]
    public Transform Camara;


    void Update()
    {
        moverCamara();
    }


    void moverCamara()
    {
        if (Input.GetMouseButton(0)) {
            float pointer_x = Input.GetAxis("Mouse X") * Time.deltaTime * VelocidadX;
            float pointer_y = Input.GetAxis("Mouse Y") * Time.deltaTime * VelocidadY;

            if (pointer_x < 0 && Camara.position.x < maxX || pointer_x > 0 && Camara.position.x > minX)
                Camara.Translate(-pointer_x, 0.0f, 0.0f);

            if (pointer_y < 0 && Camara.position.y < maxY || pointer_y > 0 && Camara.position.y > minY)
                Camara.Translate(0.0f, -pointer_y, 0.0f);

            verificarLimite();
        }
    }

    void verificarLimite()
    {
        if (Camara.position.x < minX)
            Camara.position = new Vector3(minX, Camara.position.y, Camara.position.z);

        if (Camara.position.x > maxX)
            Camara.position = new Vector3(maxX, Camara.position.y, Camara.position.z);

        if (Camara.position.y < minY)
            Camara.position = new Vector3(Camara.position.x, minY, Camara.position.z);

        if (Camara.position.y > maxY)
            Camara.position = new Vector3(Camara.position.x, maxY, Camara.position.z);
    }

}