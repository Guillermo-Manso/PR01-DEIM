using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E3cParte2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        StartCoroutine("contador");
    }
    IEnumerator contador()
    {
        int segundos = 0;
        int minutos = 0;
        int horas = 0;
        bool g = true;

        while (g)
        {   

            segundos++;

            yield return new WaitForSeconds(1f);

            if(segundos == 61)
            {
                segundos = 1;
                minutos++;
            }

            if (minutos == 60)
            {
                minutos = 0;
                horas++;

            }

            print(horas + ": " + minutos + ": " + segundos);
        }


    }
}