using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class HitSound : MonoBehaviour {

	public AudioClip soundToPlay;
	AudioSource s;

	void Awake(){
		s = this.gameObject.GetComponent<AudioSource>();
		s.clip = soundToPlay;
	}


	void OnCollisionEnter(Collision c){
		s.volume = c.relativeVelocity.magnitude/10f;
		s.pitch = Random.Range(0.2f, 6f); 
		s.Play();
	}

}


