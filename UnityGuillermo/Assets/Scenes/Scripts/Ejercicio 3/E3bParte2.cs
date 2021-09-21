using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E3bParte2 : MonoBehaviour
{


    int resultado;
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    bool acierto;
    [SerializeField] bool Suma;
    [SerializeField] bool resta;
    [SerializeField] bool multiplicacion;

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
        print("Consigue obtener 100 como resultado");


        if(multiplicacion == true)
        {
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

        if (Suma == true)
        {
            resultado = (numero1 + numero2);
            if (resultado == 100)
            {
                acierto = true;
                print(acierto);
            }

            if (resultado != 100)
            {
                acierto = false;
                print(acierto);
            }

        }

        if (resta == true)
        {
            resultado = (numero1 - numero2);
            if (resultado == 100)
            {
                acierto = true;
                print(acierto);
            }

            if (resultado != 100)
            {
                acierto = false;
                print(acierto);
            }

        }



    }

}
