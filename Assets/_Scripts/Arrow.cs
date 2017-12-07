using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {

	static int lostArrows;
	
	private Paddle paddle;
	public static bool start = false;
	private Vector3 distance;
	
	public Sprite arrow;

	// Use this for initialization
	void Start () {
		this.rigidbody2D.velocity = new Vector2 (0,0);
		paddle = GameObject.FindObjectOfType<Paddle>();
		distance = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (start == false) {
			this.transform.position = paddle.transform.position + distance;
			this.transform.rotation = new Quaternion (0, 0, 90, -90);	
			this.GetComponent<SpriteRenderer>().sprite = arrow;	
			if (Input.GetMouseButtonDown(0)) {
				start = true;
				audio.Play ();
				this.rigidbody2D.velocity = new Vector2 (2f, 10f);
				this.rigidbody2D.rotation = 250;
				}
				}
				
		else if (start == true && Input.GetMouseButtonDown(0)) {
			start = false;
			}
	    }
	    
	 void OnCollisionEnter2D() {
	 	 Vector2 tweak = new Vector2(Random.Range(0f, 0.2f), Random.Range (0f, 0.2f));
	 	 //this.rigidbody2D.velocity = this.rigidbody2D.velocity + tweak;
	 	 rigidbody2D.velocity += tweak;
	 }
}
