using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer5_7 : MonoBehaviour
{
    [SerializeField] int velocidad1;
    [SerializeField] int velocidad2;
    [SerializeField] int velocidad3;
    // Start is called before the first frame update
    void Start()
    {
        if( velocidad1 > velocidad2 && velocidad1 > velocidad3 )
        {
            Debug.Log("Ataca personaje1");
        }
        else if (velocidad2 > velocidad3)
        {
            Debug.Log("Ataca personaje2");
        }
        else
        {
            Debug.Log("Ataca personaje3");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
