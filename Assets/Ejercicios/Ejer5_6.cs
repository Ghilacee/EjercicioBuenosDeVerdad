using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer5_6 : MonoBehaviour
{
    [SerializeField] int nivelPok;
    // Start is called before the first frame update
    void Start()
    {
        if (nivelPok % 10 == 0 && nivelPok != 0)
        {
            Debug.Log("Este nivel es multiplo de 10");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
