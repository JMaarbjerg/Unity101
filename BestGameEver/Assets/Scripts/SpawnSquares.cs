using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSquares : MonoBehaviour {

    public GameObject[] prefabs;
    private GameObject[] clones;

    // Use this for initialization
    void Start () {
        DrawSquares();        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKey)
        {
            clones = GameObject.FindGameObjectsWithTag("Clone");
            for(int i = 0; i < clones.Length; i++)
            {
                Destroy(clones[i]);
            }

            DrawSquares();
        }
	}

    void DrawSquares()
    {
        for (int x = 0; x <= 120; x = x + 12)
        {
            for (int z = 0; z <= 48; z = z + 12)
            {
                int i = Random.Range(0, 5);
                Instantiate(prefabs[i], new Vector3(x, 0, z), Quaternion.identity);

            }
        }
    }
}
