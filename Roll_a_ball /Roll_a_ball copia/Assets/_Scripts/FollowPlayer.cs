using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {


	private Vector3 offset;
	public Transform target;

	// Use this for initialization
	void Start () {

		// el spacio entre el jugador y la camera para hacer que la camara le siga
		// ahy es donde esta la camara
		offset = transform.position - target.position;



	
	}
	
	// Update is called once per frame
	void Update () {

		// darle update a la posicion 
		// miniscula el objeto al que esta pegao el script
		transform.position = offset + target.position;

	
	}
}
