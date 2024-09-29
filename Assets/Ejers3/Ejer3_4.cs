using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer3_4 : MonoBehaviour
{
    // Start is called before the first frame update
    int nivel;
    [SerializeField] int experiencia;
    void Start()
    {
        Debug.Log("Tus puntos de esperiencia son : " + experiencia);
        nivel = nivel + ( 9*experiencia/5 );
        Debug.Log("Por lo tanto tu nivel es : " + nivel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
