using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = {12, 2, 34, 20};
        int somma = 0;
        int prodotto = 1;

        for (int i = 0; i < array.Length; i++)
        {
            somma += array[i];
            prodotto *= array[i];
            if(i == 1)
            {
                break;
            }
        }

        Debug.Log("La somma è: " + somma + " - Il prodotto è: " + prodotto);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
