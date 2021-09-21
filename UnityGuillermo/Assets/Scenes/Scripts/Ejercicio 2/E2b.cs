using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2b : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool g = true;
        float n = 0;
        float contador;

        while (g)
        {
            contador = n++;
            if(n > 150)
            {
                g = false;
            }

            print(contador);

        }


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
