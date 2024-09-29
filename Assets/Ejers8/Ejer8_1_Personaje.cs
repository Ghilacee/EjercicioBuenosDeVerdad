using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer8_1 : MonoBehaviour
{
    // Start is called before the first frame update

    
    // Propiedades privadas
    private string nombre;
    private float vida;
    private float experiencia;

    public global::System.Single Vida { get => vida; set => vida = value; }
    public global::System.String Nombre { get => nombre; set => nombre = value; }
    public global::System.Single Experiencia { get => experiencia; set => experiencia = value; }



    // Constructor que inicializa las propiedades sin utilizar `this`
    public Ejer8_1(string nombreInicial, float vidaInicial, float experienciaInicial)
    {
        nombre = nombreInicial;
        vida = vidaInicial;
        experiencia = experienciaInicial;
    }

    // Método para calcular el nivel
    public float CalcularNivel()
    {
        return experiencia / 1000;  // Fórmula para calcular el nivel
    }

    
}



















































