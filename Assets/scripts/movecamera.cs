﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecamera : MonoBehaviour {

	private float speed = 3f;
	// Update is called once per frame
	void Update () {
		Vector3 temp = transform.position;
		temp.x += speed * Time.deltaTime;
		transform.position = temp;
	}
}
