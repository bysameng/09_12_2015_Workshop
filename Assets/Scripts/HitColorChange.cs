using UnityEngine;
using System.Collections;

public class HitColorChange : MonoBehaviour {

	Renderer rend;

	void Awake(){
		rend = GetComponent<Renderer>();
	}

	void OnCollisionEnter(Collision c){
		float r = Random.Range(0f, 1f);
		float g = Random.Range(0f, 1f);
		float b = Random.Range(0f, 1f);
		Color newColor = new Color(r, g, b);
		rend.material.color = newColor;
	}

}
