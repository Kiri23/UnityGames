using UnityEngine;
using System.Collections;

// el nmonobehavior hereda las fisica y todo eso literalmente el game loop
public class Move : MonoBehaviour {

	// otro metodos que se pueden usar del gameLoop 
	//void awake {} 
	// void fixedUpdate 
	//void LatedUpdate 



	private Rigidbody player;
	public float speed;

	// Use this for initialization
	void Start () {

		// Gameobject mayusucula y miniscula 
		// cojer player y cojer gameObject.getcomponenty anadale rigiBody
		player = gameObject.GetComponent<Rigidbody> ();

	
	}







	// Update is called once per frame
	// para buscar infirmacion en iinternet es comand + '
	// tools - editor syntaxHighliting
	void FixedUpdate () {
		float hMov = Input.GetAxis ("Horizontal");
		float vMov = Input.GetAxis ("Vertical");

		Vector3 Movement = new Vector3 (hMov,0,vMov);

		player.AddForce (Movement * speed );

	
	}



	void OnTriggerEnter(Collider other){
		if (other.tag == "pickup"){
			Destroy (other.gameObject);
			//Debug.Log("collide);
	}
}

}

