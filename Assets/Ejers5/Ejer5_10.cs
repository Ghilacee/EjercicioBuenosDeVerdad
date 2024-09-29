using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer5_10 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float temperatura;
    void Start()
    {
        DeterminarClima();
    }
    void DeterminarClima()
    {
        
        if (temperatura <= 10)
        {
            Debug.Log("Clima: Frío");
        }
        else if (temperatura > 10 && temperatura <= 20)
        {
            Debug.Log("Clima: Nublado");
        }
        else if (temperatura > 20 && temperatura <= 30)
        {
            Debug.Log("Clima: Caluroso");
        }
        else 
        {
            Debug.Log("Clima: Tropical");
        }
    }
    
}
