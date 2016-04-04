using UnityEngine;
using System.Collections;

public class lazer : MonoBehaviour {

	public Vector3 direction;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Ray myRay = Camera.main.ScreenPointToRay (Input.mousePosition);

		GetComponent<Rigidbody> ().AddForce (myRay.direction * 20);


		//Vector3 direction = Camera.main.transform.rotation ;

	}


		void OnCollisionEnter(Collision col){
		
			if (col.gameObject.tag == "missle") {
				
				Destroy(this.gameObject);
				Debug.Log ("Splat!!!!" + col.collider);
				
			
			}
		
		}

	
}
