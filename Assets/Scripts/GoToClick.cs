using System.Collections;
using UnityEngine;

public class GoToClick : MonoBehaviour
{
	
    Transform player;
   
    UnityEngine.AI.NavMeshAgent agent;

    public Vector3 destinationPoint;
  
    private int vidaMaxima=100;
	
	private int vida;
	 
	public float speed = 10000;

    void Start()
    {
		
		vida=vidaMaxima;
		
        agent= GetComponent<UnityEngine.AI.NavMeshAgent>();
		
		agent.speed = speed;
		
        player = GameObject.FindGameObjectWithTag ("Obstaculo").transform;

    }

    void Update()
    {

		if((int)agent.transform.position.x==0){ 
            	agent.SetDestination (new Vector3(-131, 60, -4));
                
        }

        if((int)agent.transform.position.x==-131){ 
            	agent.SetDestination (new Vector3(0, 60, 0));
        }


    }

    void OnTriggerEnter(Collider obj) {
     
        if (obj.tag=="Player") {

            --vida;
			
			Debug.Log("Vida: "+vida);
			
        }

    }

}
