using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios7_6 : MonoBehaviour
{
    [SerializeField] int num;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Usando for:");
        
        for (int i = num; i >= -num; i--)
        {
            Debug.Log(i);
        }

        Debug.Log("Usando while:");
        
        int j = num;
        while (j >= -num)
        {
            Debug.Log(j);
            j--; // Decrementar el valor
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
