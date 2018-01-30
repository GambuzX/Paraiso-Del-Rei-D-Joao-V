using UnityEngine;
using System.Collections;

public class ArrowHP : MonoBehaviour {

	public int destroyHP;

	void Update () {	
		if (destroyHP >= LoseCollider.HP) { Destroy(gameObject); } 
	}
}
