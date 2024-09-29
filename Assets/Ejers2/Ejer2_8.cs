using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer2_8 : MonoBehaviour
{
    // Start is called before the first frame update
    float puntos = 120.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Puntos iniciales : " + puntos);
        float puntosResta1 = puntos / 100 * 3;
        float puntosResta2 = puntos / 100 * 6;
        float puntosResta3 = puntos / 100 * 9;
        float puntosResta4 = puntos / 100 * 12;
        float puntosResta5 = puntos / 100 * 15;
    }
}
