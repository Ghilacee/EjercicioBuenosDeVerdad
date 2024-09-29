using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer5_2 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 < 3 && numero2 < 3)
        {
            Debug.Log("Ambos numeros son menores de 3");
        }
        else
        {
            Debug.Log("Ambos numeros son mayores o iguales a 3");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
