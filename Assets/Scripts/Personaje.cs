using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    public float rotationSpeed = 10.0f;
		
    public float speed = 300f;
	
    public int vidaMaxima=100;

    private int vidaActual;
       
    private float y,posicionYInicial,posicionZInicial,posicionXInicial;
    
	Vector3 posicionInicial;
	
	bool edificio;

    private Rigidbody rigidBody;	
	
    void Start()
    {
				
		Application.targetFrameRate = 60;
		
        rigidBody = GetComponent<Rigidbody>();
		
        vidaActual =  vidaMaxima;
 
    }

	void OnCollisionEnter(Collision other) {
		
		--vidaActual;
		
    }

    void Update()
    {
				
        float y = Input.GetAxis("Vertical") * speed*Time.deltaTime;
		
        float x = Input.GetAxis("Horizontal") * speed*Time.deltaTime;

		transform.Translate(y,0.0f,-x);

		// transform.Rotate(Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
							      
    }
		
}
