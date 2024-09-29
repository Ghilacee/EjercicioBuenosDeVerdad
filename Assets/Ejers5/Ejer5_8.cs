using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer5_8 : MonoBehaviour
{
    [SerializeField] int H;
    [SerializeField] int M;
    [SerializeField] int S;
    // Start is called before the first frame update
    void Start()
    {
        if (H >= 0 && H < 24 && M >= 0 && M < 60 && S >= 0 && S < 60)
        {
            Debug.Log("Hora válida: " + H + ":" + M + ":" + S);
        }
        else
        {
            Debug.Log("Hora inválida.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
