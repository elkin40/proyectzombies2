﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour 
{
    void Start()
    {
        int caractr = 0;
  
        int rnd = Random.Range(10, 21);

        for (int i = 0; i < rnd; i++)   
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);   
            go.AddComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ; 
            Vector3 pos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)); 
            go.transform.position = pos; 
            switch (caractr)
            {
                case 0:
                    go.name = "Hero";
                    go.AddComponent<Hero>();
                    go.AddComponent<FPSMove>();
                    Camera.main.gameObject.transform.localPosition = go.transform.position;  
                    Camera.main.transform.SetParent(go.transform); 
                    go.GetComponent<Renderer>().material.color = Color.red;
                    go.tag = "Hero"; 
                    break; 
                case 1:                                                                
                    go.name = "Ciudadano"; 
                    go.AddComponent<Ciudadano>(); 
                    go.tag = "Ciudadano"; 
                    break; 		
                case 2:                                                        
                    go.name = "Zombie";
                    go.AddComponent<Zombie>(); 
                    go.tag = "Zombie"; 
                    int col = Random.Range(0, 3);  
                    break; 
            }
            caractr = Random.Range(1, 3);
        }
    }
}
