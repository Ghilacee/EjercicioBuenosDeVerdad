using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer5_1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int vidaPers1;
    [SerializeField] int vidaPers2;

    void Start()
    {
        if (vidaPers1 == vidaPers2)
        {
            Debug.Log("Los dos personajes tienen la misma vida");
        }
        else
        {
            Debug.Log("Los personajes no tienen la misma vida");

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
