using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Velocidad : MonoBehaviour
{
    public Text texto;
    public Rigidbody RB;

    void Update()
    {
        float velocidad = RB.velocity.magnitude;

        texto.text = "Velocidad: " + velocidad;
    }
}
