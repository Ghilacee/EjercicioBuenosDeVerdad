using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    // Como se define mi personaje 
    private float vida;
    private float dahno;
    private float velocidad;
    private string nombre;

    public float Vida { get => vida; set => vida = value; }
    public float Dahno { get => dahno; set => dahno = value; }
    public float Velocidad { get => velocidad; set => velocidad = value; }
    public string Nombre { get => nombre; set => nombre = value; }



    // Que puede hacer mi personaje
    // Funcionalidades 
    void Mover(float x, float y , float z )
    { 
    
    }

    void Atacar()
    {

    }

    void Saltar()
    {

    }


}
