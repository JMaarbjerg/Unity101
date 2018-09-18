using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSquares : MonoBehaviour {

    public GameObject parallel;
    public GameObject corner;

	// Use this for initialization
	void Start () {
        Instantiate(parallel);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
