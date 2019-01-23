using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameManager gameManager;
	private int previousScore;
	Text text;
	// Use this for initialization
	void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
		text = GetComponentInChildren<Text>();
	}

	// Update is called once per frame
	void Update () {

		if (gameManager.score != previousScore) {
			text.text = "Score: " + gameManager.score.ToString ();
			previousScore = gameManager.score;
		}
		
	}
}
