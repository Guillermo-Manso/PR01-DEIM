using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E3a : MonoBehaviour
{

    [SerializeField] string nombre;

    // Start is called before the first frame update
    void Start()
    {



        Saludar(nombre);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Saludar(string usuario)
    {

        print("Hola " + usuario);

    }



}
