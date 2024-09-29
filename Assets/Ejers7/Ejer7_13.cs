using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer7_13 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int numero;

    void Start()
    {
        if (EsPrimo(numero))
        {
            Debug.Log(numero + " es un número primo.");
        }
        else
        {
            Debug.Log(numero + " no es un número primo.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    bool EsPrimo(int num)
    {
        if (num <= 1) return false; 

       
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0) return false; 
        }

        return true; 
    }
}
