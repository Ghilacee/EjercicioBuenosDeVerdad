using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer4_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float resultado = ConvertirKmH_Ms(100); // Convertir 100 Km/h a m/s
        Debug.Log("100 Km/h en metros por segundo: " + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float ConvertirKmH_Ms(float velocidadKmH)
    {
        // 1 Km/h es igual a 1000 metros dividido por 3600 segundos, o 1 Km/h = 0.27778 m/s
        return velocidadKmH * 1000 / 3600;
    }
}
