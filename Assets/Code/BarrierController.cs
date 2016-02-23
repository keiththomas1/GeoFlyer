using UnityEngine;
using System.Collections;

public class BarrierController : MonoBehaviour 
{
    public GameObject playerShip;

	// Barrier prefabs
	public GameObject barrier1;

    public float spawnRange = 10.0f;

	// Timer variables
	float barrierTimer;
	float barrierTimerLength;
	bool spawningActive;

    float barrierDepth = 60.0f;

	// Use this for initialization
	void Start () 
	{
		barrierTimerLength = 0.5f;
		barrierTimer = barrierTimerLength;
		spawningActive = true;

		CreateBarrier();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if( spawningActive )
		{
			if( barrierTimer > 0.0f )
			{
				barrierTimer -= Time.deltaTime;
			}
			else
			{
				CreateBarrier();
				barrierTimer = barrierTimerLength;
				if( barrierTimerLength > 0.1f )
					barrierTimerLength -= 0.005f;
			}
		}
	}

	void CreateBarrier()
	{
        float randomPos = Random.Range(-spawnRange, spawnRange);
        float playerPos = playerShip.transform.position.x;
        Vector3 tempSpawnPos = new Vector3(randomPos + playerPos, -3.0f, barrierDepth);
		GameObject tempBarrier = (GameObject)Instantiate(barrier1, 
		                                     tempSpawnPos, 
		                                     transform.rotation);
		tempBarrier.transform.parent = transform;
	}
}
