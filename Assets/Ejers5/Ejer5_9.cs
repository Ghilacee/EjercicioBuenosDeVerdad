using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer5_9 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int tipo;

    // Arrays para almacenar el da�o y la vida de cada tipo de enemigo
    private int[] danos = { 350, 300, 300, 310, 280, 360 };
    private int[] vidas = { 650, 550, 500, 460, 490, 520 };

    void Start()
    {
        
        GenerarEnemigoPorTipo(tipo);
    }

    void GenerarEnemigoPorTipo(int tipo)
    {
     
        if (tipo >= 1 && tipo <= 6)
        {
           
            int dano = danos[tipo - 1];
            int vida = vidas[tipo - 1];

            
            Debug.Log("Enemigo de tipo " + tipo + " generado:");
            Debug.Log("Da�o: " + dano);
            Debug.Log("Vida: " + vida);
        }
        else
        {
            
            Debug.LogError("Tipo de enemigo inv�lido. Debe estar entre 1 y 6.");
        }
    }
}
