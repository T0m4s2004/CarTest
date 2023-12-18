using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreadorObjetos : MonoBehaviour
{
    [SerializeField] private Factory[] objetos;
    private Dictionary<string, Factory> objectByName;
    public Transform newPosition;

    public void Zona1()
    {
        CrearObjetos("Piramide", newPosition);
        Destroy(this);
    }
    private void Awake()
    {
        objectByName = new Dictionary<string, Factory>();

        foreach (var objeto in objetos)
        {
            objectByName.Add(objeto.objetoNombre, objeto);
        }

    }

    public Factory CrearObjetos(string objetoNombre, Transform TransformJugador)
    {
        if (objectByName.TryGetValue(objetoNombre, out Factory objetoPrefab))
        {
            Factory objetoInstanciado = Instantiate(objetoPrefab, TransformJugador.position, Quaternion.identity);
            return objetoInstanciado;
        }
        else
        {
            Debug.LogWarning($"La habilidad '{objetoNombre}' no existe en los datos de habilidades.");
            return null;
        }
    }
}
