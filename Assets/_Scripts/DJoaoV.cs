using UnityEngine;
using System.Collections;

public class DJoaoV : MonoBehaviour {

	public Sprite sprite;
	public Arrow arrow;
	private Vector2 force = new Vector2 (50f, 20f);
	// Use this for initialization
	void Start () {
		arrow = GameObject.FindObjectOfType<Arrow>(); 
	}
	
	void OnCollisionEnter2D () {
		arrow.GetComponent<SpriteRenderer>().sprite = sprite;
		arrow.rigidbody2D.AddForce(force, ForceMode2D.Impulse);
		audio.Play ();
		}
}
