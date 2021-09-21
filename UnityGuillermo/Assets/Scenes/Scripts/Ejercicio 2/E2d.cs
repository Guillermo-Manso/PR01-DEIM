using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2d : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int contador = 0;

        int aleatorio = Random.Range(1, 10);
        print("Salio " + aleatorio);

        bool g = true;

        while (g)
        {

            contador++;
            print(contador);




            if (contador == aleatorio)
            {
                g = false;
                print("Ya me harte de contar");
            }


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
