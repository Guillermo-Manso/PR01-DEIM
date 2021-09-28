using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E4c : MonoBehaviour
{

    [SerializeField] float speed = 3;
    float desplX;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {


        float desplZ = Input.GetAxis("Vertical") * speed;

        transform.Translate(Vector3.forward * desplZ * Time.deltaTime);


    }
}
