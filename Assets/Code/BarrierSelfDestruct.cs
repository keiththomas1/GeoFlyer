using UnityEngine;
using System.Collections;

public class BarrierSelfDestruct : MonoBehaviour 
{
	GameObject barrierParent;
	float startZ;

	// Use this for initialization
	void Start () 
	{
		barrierParent = GameObject.Find("MovingController");
		if( barrierParent )
		{
			startZ = barrierParent.transform.position.z;
		}
		else
		{
			startZ = 0.0f;
			Debug.Log("Error: No parent for barrier");
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if( barrierParent.transform.position.z < (startZ - 70.0f) )
			Destroy( this.gameObject );
	}
}
