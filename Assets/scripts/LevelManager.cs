using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	public void LoadLevel(string name){

		Application.LoadLevel (name);
    }
	public void Quit(){
		Debug.Log ("quit done :)");
		Application.Quit ();
	}
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel +1); 
	}
	public void LoadLastLevel(){
		Application.LoadLevel(brick.leveltracker); 
	}

	public void BrickDestroyed(){
		if (brick.breakableCount <= 0) {
			LoadNextLevel ();
		}
	}

}