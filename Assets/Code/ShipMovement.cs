using UnityEngine;
using System.Collections;

public class ShipMovement : MonoBehaviour 
{
	float lateralMovementSpeed;

	bool moving;
	bool notMovingLeft;
	Vector3 smallMovement;

	// Use this for initialization
	void Start () 
	{
		lateralMovementSpeed = 0.2f;
        moving = false;
		notMovingLeft = true;
		smallMovement = new Vector3(0.01f, 0.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 tempTranslation;
		if( Input.acceleration.x != 0.0f )
		{
			moving = true;
			tempTranslation = new Vector3(
                lateralMovementSpeed * Input.acceleration.x * Time.deltaTime * 60.0f,
                0.0f, 0.0f);
			
			transform.Translate(tempTranslation);
		}
		if( Input.GetKey(KeyCode.LeftArrow))
		{
            tempTranslation = new Vector3(
                -lateralMovementSpeed * Time.deltaTime * 60.0f, 0.0f, 0.0f);
			transform.Translate(tempTranslation);
		}
		else if( Input.GetKey(KeyCode.RightArrow))
		{
            tempTranslation = new Vector3(
                lateralMovementSpeed * Time.deltaTime * 60.0f, 0.0f, 0.0f);
			transform.Translate(tempTranslation);
		}
		else
		{
			moving = false;
		}

		if( !moving )
		{
			if( notMovingLeft )
				transform.Translate( smallMovement );
			else
				transform.Translate( -smallMovement );

			notMovingLeft = !notMovingLeft;
		}
	}
}
