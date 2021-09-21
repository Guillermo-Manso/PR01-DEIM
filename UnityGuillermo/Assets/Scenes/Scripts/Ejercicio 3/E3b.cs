using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E3b : MonoBehaviour
{


    int resultado;
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    bool acierto;

    // Start is called before the first frame update
    void Start()
    {


        Matematicas();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Matematicas()
    {
        print("Multiplica 2 numeros que den 100 como resultado");

        resultado = (numero1 * numero2);
        if(resultado == 100)
        {
            acierto = true;
            print(acierto);
        }

        if(resultado != 100)
        {
            acierto = false;
            print(acierto);
        }


    }

}
