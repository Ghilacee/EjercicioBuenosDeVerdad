using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer7_8 : MonoBehaviour
{
    
    [SerializeField] private int num1;
    [SerializeField] private int num2;

    void Start()
    {
        
        MostrarPares();
    }

    void MostrarPares()
    {
        
        int menor = num1 < num2 ? num1 : num2;
        int mayor = num1 > num2 ? num1 : num2;

        
        for (int i = menor; i <= mayor; i++)
        {
            
            if (i % 2 == 0)
            {
                
                Debug.Log(i + " es par.");
            }
        }
    }
}
