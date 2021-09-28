using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E4aParte2 : MonoBehaviour
{
    bool g = true;
    bool corrutina;
    // Start is called before the first frame update
    void Start()
    {

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
            corrutina = true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            corrutina = false;
        }

        if (corrutina == true)
        {
            StartCoroutine("contador");
        }

        else
        {
            StopCoroutine("contador");
        }
    }
}
