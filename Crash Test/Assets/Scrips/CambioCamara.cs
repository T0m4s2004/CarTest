using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioCamara : MonoBehaviour
{
    public GameObject Camara1;
    public GameObject Camara2;
    public GameObject CanvasPrincipal;
    public GameObject Canvas2;
    
    public void CambiarCamara()
    {
        Camara2.SetActive(true);
        Camara1.SetActive(false);
        Canvas2.SetActive(true);
        CanvasPrincipal.SetActive(false);
        //Time.timeScale = 0;
    }

    public void CambioCam()
    {
        Camara1.SetActive(true);
        Camara2.SetActive(false);
        CanvasPrincipal.SetActive(true);
        Canvas2.SetActive(false);
    }
}
