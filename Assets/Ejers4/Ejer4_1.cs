using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer4_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CalcularAreaCirculo(2);
        CalcularAreaTriangulo(3,6);
        CalcularAreaCuadrado(2,4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CalcularAreaCirculo(int radio)
    {
        Debug.Log("El radio del circulo es : " + radio);
        float circulo;
        circulo = (radio) * 3.14f; // EL RADIO DEBERIA ESTAR ELEVADO A DOS
        Debug.Log("El area del circulo es : " + circulo);
    }
    void CalcularAreaTriangulo(int basee , int altura)
    {
        Debug.Log("La base y la altura del triangulo es : " + basee + " y "+ altura);
        float triangulo;
        triangulo = (basee * altura) / 2;
        Debug.Log("El area del triangulo es : " + triangulo);

    }
    void CalcularAreaCuadrado(int lado1 , int lado2)
    {
        Debug.Log("El lado 1 y el lado 2 del cuadrado son : " + lado1 + " y " + lado2);
        int cuadrado;
        cuadrado = lado1 * lado2 ;
        Debug.Log("El area del cuadrado es : " + cuadrado);
    }






}
