using UnityEngine;
using System.Collections;

public class LoseColider : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D trigger){

		print ("trigger");
	}
	void OnCollisionEnter2D (Collision2D collision){
		print ("collision");

		Application.LoadLevel ("lose");
		brick.breakableCount = 0;
	}
}
