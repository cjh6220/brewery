using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispenser : MonoBehaviour
{
    public e_Beer BeerType;
    public GameObject Outline;

    private void Start()
    {
        Outline.SetActive(false);
    }

    
}
