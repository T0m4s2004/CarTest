using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetosTirados : MonoBehaviour
{
    public Text text;
    public GameObject objetos;
    public void OnCollisionEnter(Collision collision)
    {
        if(objetos.gameObject.tag == "Suelo")
        {
            text.text = ("Objetos tirados: ") + 1;

            Debug.Log("puntos");
        }
    }
}
