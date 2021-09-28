using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E4dParte2 : MonoBehaviour
{

    int n = 1;

    // Start is called before the first frame update
    void Start()
    {
        print("Click izquierdo para disparar");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine("Disparar");
        }

        if (Input.GetMouseButtonUp(0))
        {
            StopCoroutine("Disparar");
        }

    }

    IEnumerator Disparar()
    {
        while (true) {
        print("Disparo " + n);
        n++;
        yield return new WaitForSeconds(0.2f);
        }
    }

}
