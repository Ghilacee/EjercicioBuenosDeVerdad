using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer1_todos : MonoBehaviour
{
    // Start is called before the first frame update
    string nombre = "Celia";

    int vidas = 5;
    float exp = 3.5f;
    char carac = 'C';

    void Start()
    {
        Debug.Log("Hola mundo!");
        Debug.Log("Este es el primer videojuego de" + nombre);
        Debug.Log("Estoy aprendiendo C#");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
