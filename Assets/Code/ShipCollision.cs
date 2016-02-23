using UnityEngine;
using System.Collections;

public class ShipCollision : MonoBehaviour 
{
	float resetTimer;
	bool startReset;

	public GameObject movingController;
	BarrierMotion barrierMotion;

	// Use this for initialization
	void Start () 
	{
		resetTimer = 2.0f;
		startReset = false;
		GetComponent<Rigidbody>().useGravity = false;

		barrierMotion = movingController.GetComponent<BarrierMotion>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if( startReset )
		{
			resetTimer -= Time.deltaTime;
			if( resetTimer <= 0.0f )
				ResetGame();
		}
	}

	void OnCollisionEnter(Collision collision) {
		startReset = true;
		barrierMotion.SlowDown();
	}

	// Move this to global controller
	void ResetGame()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
}
