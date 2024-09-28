using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer5_4 : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;
    int division;
    // Start is called before the first frame update
    void Start()
    {
        if ( num2<0)
        {
            division = num1 / num2;
            Debug.Log("El resultado de la division es " + division);
        }
        else
        {
            Debug.Log("No se ha podido hacer la division porque el dividendo era 0 o menor que 0");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
