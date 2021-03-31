using UnityEngine;
using System.Collections;

public class brick : MonoBehaviour {
	private int times_hit ;
	public int max_hit;
	private LevelManager levelmanager;
	public Sprite[] hit_Sprites;
	public static int leveltracker;
	public static int breakableCount = 0;
	private bool isBreakable;
	
	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
		if (isBreakable) {
			breakableCount++;
		}
		times_hit = 0;
		levelmanager = FindObjectOfType<LevelManager> ();
		leveltracker = Application.loadedLevel;
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter2D (Collision2D collision){
		times_hit++;
		if (times_hit >= max_hit) {
			breakableCount--;
			levelmanager.BrickDestroyed ();
			Destroy (gameObject); 
		} else 
			LoadBrickSprites ();
			max_hit --;
		
	}
	void LoadBrickSprites(){
		this.GetComponent<SpriteRenderer> ().sprite = hit_Sprites [times_hit - 1];
	}
	void FakeWin(){
		levelmanager.LoadNextLevel ();
	}
}