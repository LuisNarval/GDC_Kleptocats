using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlador : MonoBehaviour
{

    public GameObject pastel1;
    public GameObject princesa1;
    public GameObject princesa2;
    public GameObject princesa3;
    public GameObject princesa4;
    public GameObject princesa5;
    public GameObject princesa6;
    public GameObject princesa7;
    public GameObject princesa8;
    public GameObject princesa9;
    public GameObject princesa10;
    public GameObject princesa11;
    public GameObject trono;
    public GameObject cofre;
    public GameObject martillo;
    public GameObject armadura;
    public GameObject papirobotones;
    public GameObject pastelin;
    public float contador;
    public Text corafeliz;
    public Text tesorito;
    public int opc;
    public float contadoropc ;
    public GameObject personajito;
    public GameObject esperando;
    public Text contadorregresivo;
    public bool tiempoespera = false;
    public bool pastelfelicidad = false;
    public bool conseguirobjetos = false;
    public float contadorcons;
    public GameObject esperando1;
    public Text contadorregresivo1;




    // Start is called before the first frame update
    void Start()
    {
        pastelin.SetActive(false);
        pastel1.SetActive(true);
        PlayerPrefs.SetInt("felicidad", 0);
        contador = 0.0f;
        if (PlayerPrefs.GetInt("dinerin") != 0 && PlayerPrefs.GetInt("dinerin") >= 900000000){
            PlayerPrefs.SetInt("dinerin", 0);
        }
        contadoropc = 10.0f;
        contadorcons = 10.0f;
        esperando.SetActive(false);
        esperando1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        corafeliz.text =  "" + PlayerPrefs.GetInt("felicidad");
        tesorito.text = "x " + PlayerPrefs.GetInt("dinerin");
        contadorregresivo.text = "" + contadoropc;
        contadorregresivo1.text = "" + contadorcons;
        if (PlayerPrefs.GetInt("objeto1") == 1) {
            princesa1.SetActive(true);
        }
        if (PlayerPrefs.GetInt("obejto1") != 1) {
            princesa1.SetActive(false);
        }
        if (PlayerPrefs.GetInt("objeto2") == 1)
        {
            princesa2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("obejto2") != 1)
        {
            princesa2.SetActive(false);
        }
        if (PlayerPrefs.GetInt("objeto3") == 1)
        {
            princesa3.SetActive(true);
        }
        if (PlayerPrefs.GetInt("obejto3") != 1)
        {
            princesa3.SetActive(false);
        }
        if (PlayerPrefs.GetInt("objeto4") == 1)
        {
            princesa4.SetActive(true);
        }
        if (PlayerPrefs.GetInt("obejto4") != 1)
        {
            princesa4.SetActive(false);
        }
        if (PlayerPrefs.GetInt("objeto5") == 1)
        {
            princesa5.SetActive(true);
        }
        if (PlayerPrefs.GetInt("obejto5") != 1)
        {
            princesa5.SetActive(false);
        }
        if (PlayerPrefs.GetInt("objeto6") == 1)
        {
            princesa6.SetActive(true);
        }
        if (PlayerPrefs.GetInt("obejto6") != 1)
        {
            princesa6.SetActive(false);
        }
        if (PlayerPrefs.GetInt("objeto7") == 1)
        {
            princesa7.SetActive(true);
        }
        if (PlayerPrefs.GetInt("obejto7") != 1)
        {
            princesa7.SetActive(false);
        }
        if (PlayerPrefs.GetInt("objeto8") == 1)
        {
            princesa8.SetActive(true);
        }
        if (PlayerPrefs.GetInt("obejto8") != 1)
        {
            princesa8.SetActive(false);
        }
        if (PlayerPrefs.GetInt("objeto9") == 1)
        {
            princesa9.SetActive(true);
        }
        if (PlayerPrefs.GetInt("obejto9") != 1)
        {
            princesa9.SetActive(false);
        }
        if (PlayerPrefs.GetInt("objeto10") == 1)
        {
            princesa10.SetActive(true);
        }
        if (PlayerPrefs.GetInt("obejto10") != 1)
        {
            princesa10.SetActive(false);
        }
        if (PlayerPrefs.GetInt("objeto11") == 1)
        {
            princesa11.SetActive(true);
        }
        if (PlayerPrefs.GetInt("obejto11") != 1)
        {
            princesa11.SetActive(false);
        }
        if (PlayerPrefs.GetInt("objeto12") == 1)
        {
            trono.SetActive(true);
        }
        if (PlayerPrefs.GetInt("obejto12") != 1)
        {
            trono.SetActive(false);
        }
        if (PlayerPrefs.GetInt("objeto13") == 1)
        {
            armadura.SetActive(true);
        }
        if (PlayerPrefs.GetInt("obejto13") != 1)
        {
            armadura.SetActive(false);
        }
        if (PlayerPrefs.GetInt("objeto14") == 1)
        {
            martillo.SetActive(true);
        }
        if (PlayerPrefs.GetInt("obejto14") != 1)
        {
            martillo.SetActive(false);
        }
        if (PlayerPrefs.GetInt("objeto15") == 1)
        {
            cofre.SetActive(true);
        }
        if (PlayerPrefs.GetInt("obejto15") != 1)
        {
            cofre.SetActive(false);
        }
        if (pastelfelicidad == true) {
            contador = contador + Time.deltaTime;
  
        }
        if (contador >= 3.5f){
            pastel1.SetActive(true);
            pastelin.SetActive(false);
            if (PlayerPrefs.GetInt("felicidad") >= 0 && PlayerPrefs.GetInt("felicidad") <= 100)
            {
                PlayerPrefs.SetInt("felicidad", PlayerPrefs.GetInt("felicidad") + Random.Range(1, 20));
            }
            else {
                PlayerPrefs.SetInt("felicidad", 100);
            }
           
            pastelfelicidad = false;
            contador = 0.0f;
        }

        /* if (PlayerPrefs.GetInt("felicidad") == 0) {
             if(opc == 50)
             {
                 if (PlayerPrefs.) {

                 }
             }

         }*/
        if (tiempoespera == true) {
           
         contadoropc = contadoropc - Time.deltaTime;
           
        }
        if(contadoropc < 0.1f)
        {
            if (PlayerPrefs.GetInt("felicidad") >= 0 && PlayerPrefs.GetInt("felicidad") <= 19)
            {
                PlayerPrefs.SetInt("dinerin", PlayerPrefs.GetInt("dinerin") + Random.Range(1, 5));
                
            }
            if (PlayerPrefs.GetInt("felicidad") == 20 && PlayerPrefs.GetInt("felicidad") <= 39)
            {
                PlayerPrefs.SetInt("dinerin", PlayerPrefs.GetInt("dinerin") + Random.Range(1, 10));
                
            }
            if (PlayerPrefs.GetInt("felicidad") == 40 && PlayerPrefs.GetInt("felicidad") <= 59)
            {
                PlayerPrefs.SetInt("dinerin", PlayerPrefs.GetInt("dinerin") + Random.Range(1, 15));
                
            }
            if (PlayerPrefs.GetInt("felicidad") == 60 && PlayerPrefs.GetInt("felicidad") <= 79)
            {
                PlayerPrefs.SetInt("dinerin", PlayerPrefs.GetInt("dinerin") + Random.Range(1, 20));
               
            }
            if (PlayerPrefs.GetInt("felicidad") == 80 && PlayerPrefs.GetInt("felicidad") <= 99)
            {
                PlayerPrefs.SetInt("dinerin", PlayerPrefs.GetInt("dinerin") + Random.Range(1, 30));
               
            }
            if (PlayerPrefs.GetInt("felicidad") == 100)
            {
                PlayerPrefs.SetInt("dinerin", PlayerPrefs.GetInt("dinerin") + Random.Range(10, 100));
               
            }
            tiempoespera = false;
            esperando.SetActive(false);
            contadoropc = 10.0f;
            personajito.SetActive(true);
            PlayerPrefs.SetInt("felicidad", 0);

        }
        if (conseguirobjetos == true) {
            contadorcons = contadorcons - Time.deltaTime;
        }
        if (contadorcons < 0.1f) {
            if (PlayerPrefs.GetInt("felicidad") >= 0 && PlayerPrefs.GetInt("felicidad") <= 19)
        {
            opc = Random.Range(0, 100);
        }
        if (PlayerPrefs.GetInt("felicidad") >= 20 && PlayerPrefs.GetInt("felicidad") <= 39)
        {
            opc = Random.Range(0, 80);
        }
        if (PlayerPrefs.GetInt("felicidad") >= 40 && PlayerPrefs.GetInt("felicidad") <= 59)
        {
            opc = Random.Range(0, 60);
        }
        if (PlayerPrefs.GetInt("felicidad") >= 60 && PlayerPrefs.GetInt("felicidad") <= 79)
        {
            opc = Random.Range(0, 40);
        }
        if (PlayerPrefs.GetInt("felicidad") >= 80 && PlayerPrefs.GetInt("felicidad") <= 99)
        {
            opc = Random.Range(0, 20);
        }
        if (PlayerPrefs.GetInt("felicidad") == 100)
        {
            opc = Random.Range(0, 10);
        }
            conseguirobjetos = false;
            esperando1.SetActive(false);
            personajito.SetActive(true);
            PlayerPrefs.SetInt("felicidad", 0);

        }


    }

    public void pastelitos()
    {
        pastel1.SetActive(false);
        pastelin.SetActive(true);
        pastelfelicidad = true;
       
    }

    public void destruccion() {
        esperando.SetActive(true);
        tiempoespera = true;
        personajito.SetActive(false);
        papirobotones.SetActive(false);
        
        


    }

    public void conseguir()
    {
        personajito.SetActive(false);
        conseguirobjetos = true;
        esperando1.SetActive(true);
        papirobotones.SetActive(false);

    }

   


}
