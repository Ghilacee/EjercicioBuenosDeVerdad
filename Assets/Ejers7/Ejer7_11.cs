using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer7_11 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int numero;
    void Start()
    {
        Debug.Log("Tabla de multiplicar de " + numero + ":");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Debug.Log(numero + " x " + i + " = " + resultado);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
