using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E4a : MonoBehaviour
{
    bool g = true;
    // Start is called before the first frame update
    void Start()
    {
        print("Presiona la barra espaciadora para empezar el contador");
        print("Presiona la M para empezar el contador");

    }

    IEnumerator contador()
    {
        int contador = 0;


      
     

        while (g)
        {

            contador++;
            print(contador);

            yield return new WaitForSeconds(1f);


        }


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine("contador");
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            StopCoroutine("contador");
        }
    }
}
