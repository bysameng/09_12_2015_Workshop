using UnityEngine;
using System.Collections;

public class ForceRaycast : MonoBehaviour {


	public float forceMultiplier;

	void Update () 
	{
		if (Input.GetKeyDown("e"))
		{
//			print ("e was pressed");
			Ray r = new Ray(this.transform.position, this.transform.forward);
			RaycastHit hitInfo;

			Physics.Raycast(r, out hitInfo);

			if (hitInfo.collider != null)
			{
				print(hitInfo.collider.gameObject.name);
				ApplyForceToObject(hitInfo.collider.gameObject);
			}
		}
	}


	void ApplyForceToObject(GameObject g){
		Rigidbody r = g.GetComponent<Rigidbody>();
		if (r == null)
		{
			return;
		}
		r.AddForce(this.transform.forward * forceMultiplier);
	}


}
