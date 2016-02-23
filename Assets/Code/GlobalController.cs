using UnityEngine;
using System.Collections;

public class GlobalController : MonoBehaviour 
{
	// Global identifier for the global controller.
	public static GlobalController control;

	// Use this for initialization
	void Awake() 
	{
		if( null == control )
		{
			control = this;
			// Essential for making this "global" and persistent.
			
			UnityEngine.Object.DontDestroyOnLoad( this );
		}
		else
		{
			Destroy( this );
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
