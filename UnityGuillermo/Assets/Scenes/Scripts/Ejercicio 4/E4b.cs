using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E4b : MonoBehaviour
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
        desplX = Input.GetAxis("Horizontal") * speed;

        transform.Translate(Vector3.left * -desplX * Time.deltaTime);
    }
}
