using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer7_3 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int numero = 100;
    void Start()
    {
        while (numero < 1)
        {
            Debug.Log("Numero : " + numero);
            numero--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
