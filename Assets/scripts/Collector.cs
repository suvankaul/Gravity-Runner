using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour 
{

	private float width = 0f;
	// Use this for initialization
	void Awake () 
	{
		width = GameObject.Find ("BG").GetComponent<BoxCollider2D> ().size.x;
	}

	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D target)
	{
		if (target.tag == "ground" || target.tag == "BG")
		{
			Vector3 temp = target.transform.position;
			temp.x += width * 2.98f;
			target.transform.position = temp;
		}
		if (target.tag == "Coin" || target.tag == "Rocket")
		{
			target.gameObject.SetActive (false);
		}
	}
}
