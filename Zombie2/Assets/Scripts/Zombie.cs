using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {

    public string colorName = "";
    [SerializeField]
    public BodyParts favoritePart ;
    Behaviour behaviour = Behaviour.Moving;
    
    void Start () 
    {
        gameObject.AddComponent<Rigidbody>();  //agreagamos fisicas a las primitivas
        gameObject.tag = "Zombie";
        int rnd = Random.Range (0, 3);
        switch (rnd) {       //con este suiche podemos seleccionar aleatoriamente el color deseado
        case 0:
            colorName = "Cyan";
            GetComponent<Renderer> ().material.SetColor ("_Color", Color.cyan);
            break;
        case 1:
            colorName = "Green";
            GetComponent<Renderer> ().material.SetColor ("_Color", Color.green);
            break;
        default:
            colorName = "Magenta";
            GetComponent<Renderer> ().material.SetColor ("_Color", Color.magenta);
            break;
        }

        favoritePart = (BodyParts)Random.Range (0, 5);
        StartCoroutine(DefineBehaviour());
    }
    void Update()
    {
        switch (behaviour) 
        {
        case Behaviour.Moving:
            Move ();
            break;
        }
    }
    Vector3 direction = Vector3.forward;
    float speed = 5;

    void Move ()
    {
        transform.Translate (direction*speed*Time.deltaTime);
    }

    WaitForSeconds wait = new WaitForSeconds (5);

    IEnumerator DefineBehaviour()
    {
        behaviour = (Behaviour)Random.Range (0, 2);
        direction.x = Random.Range (-1, 2);
        direction.z = Random.Range (-1, 2);
        yield return wait;
        StartCoroutine(DefineBehaviour());
    }

    public InfoZombie GetZombieInfo()
    {
        InfoZombie info = new InfoZombie();
        info.behaviour = behaviour;
        info.color = colorName;
        info.favPart = favoritePart;
        return info;
    }
}

