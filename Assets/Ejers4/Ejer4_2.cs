using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer4_2 : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        string resultado = ConstruirNombre("Pepe", "Rodríguez", "Jiménez", 20);
        Debug.Log(resultado);

    }
    // Update is called once per frame
    void Update()
    {

    }
   string ConstruirNombre(string nombre1, string apellido1 , string apellido2 , int edad)
   {
        return "La persona se llama " + nombre1 + " " + apellido1 + " " + apellido2 + " y tiene " + edad + " años.";

   }

}
