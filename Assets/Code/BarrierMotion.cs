using UnityEngine;
using System.Collections;

public class BarrierMotion : MonoBehaviour 
{
    public float barrierSpeed;
    public float barrierSpeedDefault = 1.0f;
    public float barrierSpeedMax = 2.0f;
    public float barrierSpeedIncrease = 0.1f;

    public float speedUpTimerMax = 5.0f;
    float speedUpTimer;

	// Use this for initialization
	void Start () 
	{
        barrierSpeed = barrierSpeedDefault;
        speedUpTimer = speedUpTimerMax;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(0.0f, 0.0f,
            -barrierSpeed * Time.deltaTime * 60.0f);

        if (barrierSpeed < barrierSpeedMax)
        {
            speedUpTimer -= Time.deltaTime;
            if (speedUpTimer <= 0.0f)
            {
                barrierSpeed += barrierSpeedIncrease;
                speedUpTimer = speedUpTimerMax;
            }
        }
	}

	public void SlowDown()
	{
		barrierSpeed = 0.1f;
	}

    public void SpeedUp(float increment)
    {
        if (barrierSpeed < barrierSpeedMax)
        {
            barrierSpeed += increment;
        }
    }

    public void ResetSpeed()
    {
        barrierSpeed = barrierSpeedDefault;
    }
}
