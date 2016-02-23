using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour 
{
	float inputRotateSpeed;
	float automaticRotateSpeed;

	// Use this for initialization
	void Start () 
	{
		inputRotateSpeed = 1.0f;
		automaticRotateSpeed = 2.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{	
		Vector3 tempRotation;
		if( Input.acceleration.x != 0.0f )
		{
			tempRotation = new Vector3(0.0f, 0.0f,
                inputRotateSpeed * Input.acceleration.x * Time.deltaTime * 60.0f);
			
			if( (transform.rotation.z < .2f && Input.acceleration.x > 0.0f)
			   || (transform.rotation.z > -.2f && Input.acceleration.x < 0.0f) )
			{
				transform.Rotate(tempRotation);
			}
		}
		else if( Input.GetKey(KeyCode.LeftArrow))
		{
            tempRotation = new Vector3(0.0f, 0.0f, inputRotateSpeed * Time.deltaTime * 60.0f);
			transform.Rotate(tempRotation);
		}
		else if( Input.GetKey(KeyCode.RightArrow))
		{
            tempRotation = new Vector3(0.0f, 0.0f, -inputRotateSpeed * Time.deltaTime * 60.0f);
			transform.Rotate(tempRotation);
		}
		else
		{
			if(transform.rotation.eulerAngles.z > 1.0f &&
			   transform.rotation.eulerAngles.z < 180.0f)
			{
                tempRotation = new Vector3(
                    0.0f, 0.0f, -automaticRotateSpeed * Time.deltaTime * 60.0f);
				transform.Rotate(tempRotation);
			}
			else if(transform.rotation.eulerAngles.z < 359.0f &&
			        transform.rotation.eulerAngles.z > 180.0f)
			{
                tempRotation = new Vector3(
                    0.0f, 0.0f, automaticRotateSpeed * Time.deltaTime * 60.0f);
				transform.Rotate(tempRotation);
			}
		}
	}
}
