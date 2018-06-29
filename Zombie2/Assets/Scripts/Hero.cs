using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hero : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            print("Waaar los zombies " + collision.gameObject.GetComponent<Zombie>().colorName + " que estamos " + " NOS GUSTA " + collision.gameObject.GetComponent<Zombie>().favoritePart);
        }
    }

    void Start()
    {
        gameObject.AddComponent<Rigidbody>();
        gameObject.AddComponent<FPSMove>();
        gameObject.AddComponent<FPSAim>();
    //  colorName = "Yellow";
//            GetComponent<Renderer> ().material.SetColor ("_Color", Color.yellow);
      
    }
    public float speed = 2f;  //velocidad

    void Update()
    {
        float distance = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        transform.Rotate(0,5,0);
    }
}

//IEnumerator NombreCorutina ()
//{
  //  yield new WaitForSeconds (5);

    //StartCorutine(NombreCorutina())
//}