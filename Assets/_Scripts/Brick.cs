using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	
	public Sprite[] hitSprites;
	public AudioClip sound;
	public GameObject smoke;
	
	public static int brickCount = 0;
	
	private int timesHit;
	
	private LevelManager levelManager;
	
	void OnCollisionEnter2D(Collision2D collider) {
		AudioSource.PlayClipAtPoint(sound, transform.position, 0.5f);
		timesHit++;		
		int maxHits = hitSprites.Length + 1;
		
		if (timesHit >= maxHits && this.tag == "Breakable") {
			brickCount--;			
			Instantiate (smoke, gameObject.transform.position, Quaternion.identity);			
			Destroy (gameObject);}
		else {
			LoadSprites (); }
		if (brickCount <= 0) { NextLevel (); }
		}
			
	void Start () {
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		if (this.tag == "Breakable") { brickCount++; }
		}

	void LoadSprites() {
		int spriteIndex = timesHit - 1;
		if (hitSprites[spriteIndex]) {
		this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		} else { Debug.LogError("Sprite missing!"); }
	}
		
	void NextLevel() {
		levelManager.LoadNextLevel();
		}
}