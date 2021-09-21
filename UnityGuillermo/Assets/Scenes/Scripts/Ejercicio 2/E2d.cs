using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E2d : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        bool g = true;
        int aleatorio;
        while (g)
        {
            aleatorio = Random.Range(1, 100);
            print(aleatorio);
            if(aleatorio == 7)
            {
                g = false;
                print("Si. Era " + aleatorio);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
