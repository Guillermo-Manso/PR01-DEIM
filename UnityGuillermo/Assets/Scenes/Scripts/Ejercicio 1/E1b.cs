using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1b : MonoBehaviour
{


    [SerializeField] int numeroentero = 10;
    [SerializeField] float numerodecimal = 7;
    [SerializeField] string nombre = "Guillermo";
    [SerializeField] bool boleana = true;


    // Start is called before the first frame update
    void Start()
    {

        print(numeroentero);
        print(numerodecimal);
        print(nombre);
        print(boleana);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
