using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer2_2 : MonoBehaviour
{
    // Start is called before the first frame update
    int vidas = 5;
    float exp = 3.5f;
    char carac = 'C';

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado un frame"); // esto se repite porque se llama al update , a cada frame
        Debug.Log("El valor de vida es: " + vidas);
        Debug.Log("El valor de exp es: " + exp);
        float resultadoSuma = vidas + exp;
        Debug.Log("La suma de vida y de exp es " + resultadoSuma);
        float resultadoResta = vidas - exp;
        Debug.Log("La suma de vida y de exp es " + resultadoResta);
    }
}
