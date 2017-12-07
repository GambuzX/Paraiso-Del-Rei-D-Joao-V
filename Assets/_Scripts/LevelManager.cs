using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Brick.brickCount = 0;
		Application.LoadLevel(name);
	}
	
	public void LoadNextLevel () {
		Brick.brickCount = 0;
		Arrow.start = false;
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	
	public void QuitRequest () {
		Application.Quit ();
	}
	

}