using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer7_7 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    void Start()
    {
        int menor, mayor;

       
        if (numero1 < numero2)
        {
            menor = numero1;
            mayor = numero2;
        }
        else
        {
            menor = numero2;
            mayor = numero1;
        }

        
        for (int i = menor; i <= mayor; i++)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
