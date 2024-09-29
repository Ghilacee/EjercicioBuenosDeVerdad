using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer7_9 : MonoBehaviour
{
    [SerializeField] private int num;

    void Start()
    {
        
        MostrarMultiplosDeTres();
    }

    void MostrarMultiplosDeTres()
    {
        
        for (int i = 1; i <= num; i++)
        {
            
            if (i % 3 == 0)
            {
                
                Debug.Log(i + " es múltiplo de 3");
            }
        }
    }
}
