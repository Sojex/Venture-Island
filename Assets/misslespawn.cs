using UnityEngine;
using System.Collections;

public class misslespawn : MonoBehaviour {


	public GameObject missle;
	public Transform spawn;

	public float timer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		timer += Time.deltaTime;



		if (timer > 5f) {

			Instantiate(missle,spawn.position,spawn.rotation);
			timer=0f;
		}


	}
}
