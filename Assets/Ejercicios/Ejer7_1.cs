using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer7_1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int numero = 0;
    void Start()
    {
        //Programa que muestre los números del 1 al 100 utilizando la estructura while 
        while ( numero < 100 )
        {
           Debug.Log("Numero : "+ numero);
           numero++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
