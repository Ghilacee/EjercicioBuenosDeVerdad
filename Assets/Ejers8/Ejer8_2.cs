using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer8_2SistemaVida : MonoBehaviour
{
    // Start is called before the first frame update
  
    [SerializeField] private float vidaInicial;

   
    private float vidaActual;

    public Ejer8_2SistemaVida(float vidaInicial)
    {
        vidaActual = vidaInicial; 
    }

    public float RecibirCura(float cantidad)
    {
        if (cantidad < 0)
        {
            
            return -1;
        }
        else
        {
           
            vidaActual += cantidad;
            return vidaActual;
        }
    }

   
    public float RecibirDanho(float danho)
    {
        if (danho < 0)
        {
            
            return -1;
        }
        else
        {
           
            vidaActual -= danho;

            
            if (vidaActual <= 0)
            {
                vidaActual = 0;
                return 0;
            }
           
            return vidaActual;
        }
    }

    
    public float GetVidaActual()
    {
        return vidaActual;
    }
}

