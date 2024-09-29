using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer3_7 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float Base;
    [SerializeField] float Altura;
    float area;
    void Start()
    {
      area = (Base * Altura) / 2;
      Debug.Log("El area del triangulo es " + area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
