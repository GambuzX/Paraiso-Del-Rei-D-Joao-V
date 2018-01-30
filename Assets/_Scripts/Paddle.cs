using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public bool playtest;
	
	float MousePositionInGM;
	private Arrow arrow;
	
	void Start () {
		arrow = GameObject.FindObjectOfType<Arrow>();
		}
	
	void Update () {
		if (playtest) {
			PlayTest (); }
		else {
			MoveWithMouse();
		}

	}
	
	void MoveWithMouse() {
		MousePositionInGM = (Input.mousePosition.x / Screen.width * 16);
		Vector3 paddlePosition = new Vector3(Mathf.Clamp (MousePositionInGM, 1.432f, 14.568f), this.transform.position.y, 0f);
		
		this.transform.position = paddlePosition;
	}
	
	void PlayTest() {
		Vector3 PlayTestPosition = new Vector3(Mathf.Clamp(arrow.transform.position.x, 1.432f, 14.568f) , this.transform.position.y, 0f);
		this.transform.position = PlayTestPosition;
	}
}
