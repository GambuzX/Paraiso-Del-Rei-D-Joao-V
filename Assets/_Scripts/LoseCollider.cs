using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	private LevelManager levelManager;
	
	public static int HP = 3;
	
	void Start() {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	void OnTriggerEnter2D (Collider2D collider) {
		HP --;
		Arrow.start = false;
		if (HP < 0) {
			levelManager.LoadLevel("Lose");
			HP = 3;
			}
		}

	/*void OnTriggerEnter2D (Collider2D collider) {
		Application.LoadLevel("Lose");
		} */

}
