using UnityEngine;
using System.Collections;

public class WallGeneration : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Generate a point that is <this width> away from starting point
    // Transform it to fit that line between start and end
    // Figure out how to calculate a rotation based on two points

    /* void CreateWall()
    {
        float randomPos = Random.Range(-spawnRange, spawnRange);
        float playerPos = playerShip.transform.position.x;
        Vector3 tempSpawnPos = new Vector3(randomPos + playerPos, -1.0f, barrierDepth);
		GameObject tempBarrier = (GameObject)Instantiate(barrier1, 
		                                     tempSpawnPos, 
		                                     transform.rotation);
		tempBarrier.transform.parent = transform;
    } */
}
