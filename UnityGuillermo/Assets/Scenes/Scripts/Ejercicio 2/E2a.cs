using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2a : MonoBehaviour
{

    float n = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (n <= 100)
        {
            float contador = n++;
            print(contador);
        }




    }
}
