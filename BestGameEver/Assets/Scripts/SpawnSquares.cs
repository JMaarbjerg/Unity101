using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSquares : MonoBehaviour {

    public GameObject parallel;
    public GameObject corner;
    public int[] anglePool = { 0, 180, 90, 270 };
    public Quaternion newAngle = Quaternion.identity;

	// Use this for initialization
	void Start () {
        for (int x = 0; x <= 60; x = x+12) {
            float rnd = Random.value;
            if(rnd < 0.66)
            {                
                int i = Random.Range(0, 3);
                Debug.Log(i);
                newAngle.y = anglePool[i];
                newAngle = new Quaternion(newAngle.x, 90, newAngle.z, newAngle.w);
                Debug.Log(newAngle.y);
                Instantiate(corner, new Vector3(x, 0, 0), newAngle);
            }
            
            else
            {
                int i = Random.Range(0, 1);
                newAngle.y = anglePool[i];
                Instantiate(parallel, new Vector3(x, 0, 0), newAngle);
            }
        }
        /*
        Debug.Log(anglePool[0]);
        Debug.Log(anglePool[1]);
        Debug.Log(anglePool[2]);
        Debug.Log(anglePool[3]);
        */  
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
