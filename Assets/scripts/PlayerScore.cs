using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScore : MonoBehaviour
{

	private Text scoreText;
	private int score = 0;
	// Use this for initialization
	void Start ()
	{
		scoreText = GameObject.Find ("ScoreText").GetComponent<Text> ();
		scoreText.text = "0";
	}

	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D target)
	{
		if (target.tag == "Coin") {
			score = score + 10;
			scoreText.text = score.ToString ();
			target.gameObject.SetActive (false);
		}
		if (target.tag == "coin1") {
			score = score + 5;
			scoreText.text = score.ToString ();
			target.gameObject.SetActive (false);
		}
		if (target.tag == "Rocket") {
			transform.position = new Vector3 (0, 1000, 0);
			target.gameObject.SetActive (false);
			scoreText.text = "Game Over";
			StartCoroutine (RestartGame ());
		}
	}

	IEnumerator RestartGame ()
	{
		yield return new WaitForSecondsRealtime (2f);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name); 
	}
}

