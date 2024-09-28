using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer7_10 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    void Start()
    {
        int menor = numero1 < numero2 ? numero1 : numero2;
        int mayor = numero1 > numero2 ? numero1 : numero2;

        for (int i = menor; i <= mayor; i++)
        {
            
            string signo = i >= 0 ? "positivo" : "negativo";

            
            string paridad = i % 2 == 0 ? "par" : "impar";

            
            Debug.Log(i + " es " + signo + " y " + paridad);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
