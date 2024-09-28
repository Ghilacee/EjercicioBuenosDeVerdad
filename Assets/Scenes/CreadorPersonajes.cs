using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorPersonajes : MonoBehaviour
{
    // Start is called before the first frame update
    int numero = 5;
    string texto = "Chalao";
    float num = 3.4f;
   [SerializeField] Personaje link;
   [SerializeField] Personaje mario;
    void Start()
    {
        link.Vida = 200;
        link.Velocidad = 100;
        link.Dahno = 150;
        link.Nombre = "Link"; 

        mario.Vida = 50;

        //link.Mover(3, 0, -1);
        
    }

    
}
