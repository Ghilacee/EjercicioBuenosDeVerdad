using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer4_3 : MonoBehaviour
{
    // Start is called before the first frame update
    

    void Start()
    {
        Debug.Log("100 euros en dólares: " + Convertir(100, "euro"));
        Debug.Log("100 dólares en euros: " + Convertir(100, "dolar"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float Convertir(float cantidad, string moneda)
    {
        // Si la moneda es "euro", convertir a dólares
        if (moneda == "euro")
        {
            return cantidad * 1.1f; // Ejemplo de tasa de conversión: 1 euro = 1.1 dólares
        }
        // Si la moneda es "dolar", convertir a euros
        else if (moneda == "dolar")
        {
            return cantidad * 0.91f; // Ejemplo de tasa de conversión: 1 dólar = 0.91 euros
        }
        else
        {
            Debug.LogError("Moneda no válida. Use 'euro' o 'dolar'.");
            return 0;
        }
    }
}


