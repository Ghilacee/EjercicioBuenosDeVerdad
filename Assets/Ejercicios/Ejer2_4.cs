using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer2_4 : MonoBehaviour
{
    // Start is called before the first frame update
    int vidas = 5;
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Variable vidas: " + vidas);
        int incremento77 = vidas + 77;
        Debug.Log("Variable vidas incrementa 77: " + incremento77);
        int drecremento3 = incremento77 - 3;
        Debug.Log("De la variable incrementada de vidas decremento 3: " + drecremento3);
        int cuatriplico = drecremento3 * 4;
        Debug.Log("Y por ultimo , cuatriplico su valor: " + cuatriplico);
    }
}
