using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSAim : MonoBehaviour 
{

	private void Start () 
	{
		
	}
	//MOVEMOSN LA CAMARA CON EL RATON
	float mouseX;
	float mouseY;
	public bool InvertedMouse;
	//una variable que se restablece cada vez con el update
	 void Update () 
	{
	 Vector3 mousePosition = Input.mousePosition;
	 mouseX += Input.GetAxis("Mouse X") ;
	 if (InvertedMouse)
	 {
       mouseY += Input.GetAxis("Mouse Y") ;
	 } else
	 {
	   mouseY -= Input.GetAxis("Mouse Y") ;	 
	 }
	 transform.eulerAngles = new Vector3(mouseY,mouseX,0);
	}
}
