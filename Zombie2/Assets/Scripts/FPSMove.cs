using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMove : MonoBehaviour
{
    private void Start()
    {

    }
    public float speed = 0.1f;  //nos permite mover mas lento
                                //-= PARA MOVERLO ATRAS Y += PARA MOVERLA ADELANTE
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed; //mover rapido la camamra
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed; //	el forward para mover a la derecha
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed;  // el right para mover a la izquierda
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed;
        }
    }
}
