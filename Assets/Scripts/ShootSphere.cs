using UnityEngine;
using System.Collections;

public class ShootSphere : MonoBehaviour {

	public GameObject spherePrefab;
	public float forceMultiplier;

	void Update () {
		if (Input.GetKeyDown("f"))
		{
			print ("f was pressed");
			Shoot();
		}
	}

	
	void Shoot(){
		GameObject newSphere = Instantiate(spherePrefab) as GameObject;
		newSphere.transform.position = this.transform.position + this.transform.forward;

		Rigidbody r = newSphere.GetComponent<Rigidbody>();
		r.AddForce(transform.forward * forceMultiplier);

		Destroy(newSphere, 5f);
	}

}
