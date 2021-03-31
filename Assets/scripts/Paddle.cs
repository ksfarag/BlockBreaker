using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 paddlepos = new Vector3 (0f, transform.position.y /*y axis stays the same*/, 0f);
		float mouseposinblocks = Input.mousePosition.x / Screen.width * 16;

		paddlepos.x = Mathf.Clamp(mouseposinblocks, 1.28f, 14.8f);
		this.transform.position = paddlepos; 



	}
}
