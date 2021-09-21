using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2c : MonoBehaviour
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
            if (n > 150)
            {
                g = false;;
            }

            print(contador);

            if (g == false)
            {
                print("Alcanzaste el limite");

            }

        }





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
