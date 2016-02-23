using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour 
{
	public GameObject scoreTextObject;
	TextMesh scoreText;

	int score;

	// Use this for initialization
	void Start () 
	{
		scoreText = scoreTextObject.GetComponent<TextMesh>();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		score += 1;
		scoreText.text = score.ToString();
	}
}
