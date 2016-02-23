using UnityEngine;
using System.Collections;

public class WallBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0.0f, 0.0f, -0.1f);
	}
}
