using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer7_12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int resultado = SumarTodosLosNumeros(3, 7); // Cambia estos valores para probar con otros números
        Debug.Log("La suma de todos los números entre 3 y 7 es: " + resultado);
        int SumarTodosLosNumeros(int num1, int num2)
        {
            int suma = 0;

            // Determinar el menor y el mayor de los dos números
            int menor = num1 < num2 ? num1 : num2;
            int mayor = num1 > num2 ? num1 : num2;

            // Sumar todos los números entre menor y mayor (inclusive)
            for (int i = menor; i <= mayor; i++)
            {
                suma += i;
            }

            return suma; // Devolver la suma calculada
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
