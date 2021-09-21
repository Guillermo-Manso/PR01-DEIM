using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E3c : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        StartCoroutine("contador");
    }
    IEnumerator contador()
    {
        int contador = 0;

        int limite = 10;
        bool g = true;

        while (g)
        {   

            contador++;
            print(contador);

            yield return new WaitForSeconds(1f);


            if (contador == limite)
            {
                g = false;
                print("Ya me harte de contar");
            }


        }


    }
}