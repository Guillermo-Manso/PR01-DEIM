using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E4bParte2 : MonoBehaviour
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

        if (transform.position.x >= 4)
        {
            transform.position = new Vector3(4, transform.position.y, transform.position.z);
        }
        else if (transform.position.x <= -4)
        {
            transform.position = new Vector3(-4, transform.position.y, transform.position.z);
        }
    }
}
