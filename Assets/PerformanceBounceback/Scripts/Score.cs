using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameManager gameManager;
	private Text text;
	private int lastScore;

	// Use this for initialization
	void Start () {
		text = GetComponentInChildren<Text>();
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
		lastScore = gameManager.score;

	}
	
	// Update is called once per frame
	void Update () {
		if (gameManager.score > lastScore)
		{

			text.text = "Score: " + gameManager.score.ToString();
		}
		
	}
}
