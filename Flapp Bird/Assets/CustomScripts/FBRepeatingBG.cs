using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBRepeatingBG : MonoBehaviour {

	private BoxCollider2D _boxCollider2d;

	private float groundHorizontalLength;

	// Use this for initialization
	void Start () {
		_boxCollider2d = GetComponent<BoxCollider2D> ();
		groundHorizontalLength = _boxCollider2d.size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -groundHorizontalLength) {
			repositionBackground ();
		}
	}

	void repositionBackground() {
		Vector2 groundOffset = new Vector2 (groundHorizontalLength * 2 , 0);
		transform.position = (Vector2)transform.position + groundOffset;


	}
}
