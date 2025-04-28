using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num = 0;   
        int index = 10;  
        while (index > 0)
        {
            num += 1;
            Debug.Log("Indice attuale: " + index + " - Numero: " + num);
            index--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
