﻿using UnityEngine;
using System.Collections;

public class AtackBallGenerator : MonoBehaviour {

    public GameObject AtackBallPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            GameObject AtackBall =
                Instantiate(AtackBallPrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            AtackBall.GetComponent<AtackBallController>().Shoot(
                new Vector3(0, 200, 2000));
        }
	}
}
