using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciudadano : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            print("quieren  " + collision.gameObject.GetComponent<Zombie>().colorName + " que estamos lleenos de " + " NOS GUSTA " + collision.gameObject.GetComponent<Zombie>().favoritePart);
        }
    }

    void Start()
    {
        gameObject.AddComponent<Rigidbody>();
        gameObject.AddComponent<FPSMove>();
        gameObject.AddComponent<FPSAim>();


    }
    public float speed = 0.1f;  //velocidad
    void Update()

    {
        float distance = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        transform.Rotate(0, 1, 0);
    }
}

	

