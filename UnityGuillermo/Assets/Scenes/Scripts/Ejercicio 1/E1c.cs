using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1c : MonoBehaviour
{

    [SerializeField] float numero1 = 7;
    [SerializeField] float numero2 = 8;
  



    // Start is called before the first frame update
    void Start()
    {
        float resultado;
        resultado = numero1 + numero2;

        print(numero1 + " +" + numero2 + " = " + resultado);
        print("La suma de " + numero1 + " + " + numero2 + " es " + resultado);



        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
