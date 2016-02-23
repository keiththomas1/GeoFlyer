using UnityEngine;
using System.Collections;

public class ColorPhaser : MonoBehaviour {
    float colorTimerMax = 1.3f;
    float colorTimerCurrent = .4f;
    Renderer renderer;
    Color nextColor;

	// Use this for initialization
    void Start()
    {
        renderer = GetComponent<Renderer>();
        nextColor = renderer.material.color;
	}
	
	// Update is called once per frame
    void Update() {
        colorTimerCurrent -= Time.deltaTime;
        if (colorTimerCurrent <= 0.0f)
        {
            colorTimerCurrent = colorTimerMax;
            var tempColor = renderer.material.color;
            float outH, outS, outV;
            Color.RGBToHSV(tempColor, out outH, out outS, out outV);

            var randomDifference = Random.Range(0.1f, 0.2f);
            var randomSign = Random.Range(0.0f, 1.0f) < 0.5f ? -1 : 1;
            nextColor = Color.HSVToRGB(
                outH + (randomDifference * randomSign), outS, outV);
        }
        ColorShift();
	}

    void ColorShift()
    {
        var currentColor = renderer.material.color;
        renderer.material.color = Color.Lerp(
            currentColor, nextColor, Time.deltaTime);
    }
}
