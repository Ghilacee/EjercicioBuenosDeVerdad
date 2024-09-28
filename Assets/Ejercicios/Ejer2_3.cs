using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer2_3 : MonoBehaviour
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
        float producto = vidas * exp;
        float cociente = vidas / exp;
        float resto = vidas % exp;
        int doble = vidas * 2;
        float triple = exp * 3;
        
        Debug.Log("El produccto de vida y exp : " + producto);
        Debug.Log("El cociente de vida y exp : " + cociente);
        Debug.Log("El resto de vidas y exp: " + resto);
        Debug.Log("El doble de vidas" + doble);
        Debug.Log("El triple de exp" + triple);
    }
}
