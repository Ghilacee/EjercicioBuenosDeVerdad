using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer3_3 : MonoBehaviour
{
    // Start is called before the first frame update
     [SerializeField] int numeroEntero;
    int numeroDoble;
    int numeroTriple;
    void Start()
    {
        Debug.Log("El numero entero elegido es  : " + numeroEntero);
        numeroDoble = numeroEntero * 2;
        numeroTriple = numeroEntero * 3;
        Debug.Log("El dobre de este numero es : " + numeroDoble);
        Debug.Log("El triple de este numero es : " + numeroTriple);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
