using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer2_7 : MonoBehaviour
{
    // Start is called before the first frame update

    int framear = 7;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Unidades de oro frameadas en un segundo por el personaje : " + framear);
        int framear4 = framear + 14400;
        Debug.Log("Unidades de oro frameadas en cuatro horas por el personaje : " + framear4);
    }
}
