using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FlappyBirdGameController : MonoBehaviour {

	public static FlappyBirdGameController _fbgc;

	public float scrollSpeed = -1.5f;
	public bool isGameOver = false;
	private int score = 0;

	public Text score_text;
	public GameObject gameOverText;


	void Awake () {
		if (_fbgc == null) {
			_fbgc = this;
		} else if (_fbgc != this) {
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isGameOver && Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}
	}

	public void gameScore() 
	{
		if (isGameOver) {
			return;
		}
		score++;
		score_text.text = "Score : " + score;
	}

	public void playerDie() {
		isGameOver = true;
		gameOverText.SetActive (true);
	}
}
