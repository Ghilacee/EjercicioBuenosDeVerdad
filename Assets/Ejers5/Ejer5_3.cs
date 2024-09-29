using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer5_3 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int numero;
    void Start()
    {
        if (numero >= 1 && numero <= 9)
        {
            Debug.Log("El numero esta comprendido entre el 1 y el 9 ");
        }
        else
        {
            Debug.Log("El numero no esta comprendido entre el 1 y el 9");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
