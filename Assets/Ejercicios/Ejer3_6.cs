using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer3_6 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float velocidad;
    float velocidadMetros;
    void Start()
    {
        Debug.Log("La velocidad es de : " + velocidad + "km/h");
        velocidadMetros = velocidad * 1000/1 * 1/3600 ;
        Debug.Log("La velocidad es de : " + velocidadMetros + "m/s");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
