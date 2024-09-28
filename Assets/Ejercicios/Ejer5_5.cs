using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer5_5 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int vida;
    void Start()
    {
        if (vida / 2 == 0)
        {
            Debug.Log("Vida es un numero par");
        }
        else
        {
            Debug.Log("Vida es un numero impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
