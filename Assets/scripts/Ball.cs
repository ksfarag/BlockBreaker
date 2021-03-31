using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private Paddle paddle;
	private bool StartGame=true;
	private Vector3 DiffBetBalAndPadd;
	// Use this for initialization
	void Start () {
	   	paddle = GameObject.FindObjectOfType<Paddle> ();
		 DiffBetBalAndPadd = this.transform.position - paddle.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		if (StartGame == true) {
			this.transform.position = paddle.transform.position + DiffBetBalAndPadd;
			if (Input.GetMouseButtonDown (0))
			{
				this.GetComponent<Rigidbody2D>().velocity = new Vector2 (Random.Range(-5,5), 12f);
				StartGame=false;
			}
		}
	}
}
