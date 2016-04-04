using UnityEngine;
using System.Collections;

public class lazerbeam : MonoBehaviour {

	public Transform lazer;




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Ray myRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		//Camera.main.transform.LookAt (myRay.direction );
		Debug.DrawRay (myRay.origin, myRay.direction * 500, Color.red);

		if (Input.GetMouseButton (0)) {

			Instantiate (lazer, Camera.main.transform.position  ,Camera.main.transform.rotation);


		}
	}
}
