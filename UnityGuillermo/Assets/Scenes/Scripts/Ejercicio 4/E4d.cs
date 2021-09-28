using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E4d : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int n;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            n++;
            print("Disparo " + n);
        } 
    }



}
