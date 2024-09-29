using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer3_5 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int Rcircunferencia;
    float LongiCircunferencia;
    float AreaCircunferencia;
    void Start()
    {
        LongiCircunferencia = 2 * 3.14f * Rcircunferencia;
        Debug.Log("Longitud circunferencia : " + LongiCircunferencia);
        
        AreaCircunferencia = 3.14f * Rcircunferencia; // no me deja elevarlo a dos
        Debug.Log("Area de la circunferencia : " + AreaCircunferencia);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
