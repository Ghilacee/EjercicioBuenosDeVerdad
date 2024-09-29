using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer2_6 : MonoBehaviour
{
    // Start is called before the first frame update
    int puntuacion1 = 1;
    int puntuacion2 = 2;
    int puntuacion3 = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Puntuacion 1: " + puntuacion1);
        Debug.Log("Puntuacion 2: " + puntuacion2);
        Debug.Log("Puntuacion 3: " + puntuacion3);
        int mediaPuntuaciones = (puntuacion1 + puntuacion2 + puntuacion3) % 3;
        Debug.Log("Media de las puntuaciones: " + mediaPuntuaciones);
    }
}
