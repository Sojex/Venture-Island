using UnityEngine;
using System.Collections;

public class missleScript : MonoBehaviour {

	public GameObject player;
	public GameObject missle;
	public Vector3 destination;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		destination = player.transform.position;

		Vector3 direction = Vector3.Normalize (destination - missle.transform.position);

		transform.LookAt (destination);

		GetComponent<Rigidbody> ().AddForce (direction * 30);

		Debug.Log ("direction=" + direction);
	
	
	}


	void OnCollisionEnter(Collision col){
		
		if (col.gameObject.tag=="lazer") {
			
			Destroy(this.gameObject);
			Debug.Log ("Splat!!!!" + col.collider);
			
			
		}


}

}