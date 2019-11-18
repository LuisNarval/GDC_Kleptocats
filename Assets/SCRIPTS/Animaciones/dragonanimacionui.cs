using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dragonanimacionui : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public float tiepitbirips;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        tiepitbirips = tiepitbirips + Time.deltaTime;
        if (tiepitbirips >= 0.2f)
        {
            gameObject.GetComponent<Image>().sprite = sprite1;
            //gameObject.GetComponent<UnityEngine.UI.Image> ().sprite = sprite1;
        }
        if (tiepitbirips >= 0.4f)
        {
            gameObject.GetComponent<Image>().sprite = sprite2;
            // gameObject.GetComponent<UnityEngine.UI.Image> ().sprite = sprite2;
        }
        if (tiepitbirips >= 0.6f)
        {
            gameObject.GetComponent<Image>().sprite = sprite3;
            //gameObject.GetComponent<UnityEngine.UI.Image> ().sprite = sprite3;
            tiepitbirips = 0.0f;
        }
    }
    
}
