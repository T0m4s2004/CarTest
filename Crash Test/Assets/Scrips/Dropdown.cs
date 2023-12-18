using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropdown : MonoBehaviour
{
    public Dropdown dropdown;

    public GameObject dropdownPrefab;
    public void auto()
    {
        dropdownPrefab.SetActive(true);
    }
}
