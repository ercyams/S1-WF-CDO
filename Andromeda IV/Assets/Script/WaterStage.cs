using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class WaterStage : MonoBehaviour
{

	private bool shouldLerp = false;
	public float timeStartedLerping;
	public float lerpTime;
	public Vector3 endPosition;
	public Vector3 startPosition;
	public Slider waterLevel;
	//public InputField StartY;
	public InputField Peak;
	public InputField SetTime;

	public void StartLerping(){
		timeStartedLerping = Time.time;
		shouldLerp = true;
	}

	public Vector3 Lerp(Vector3 start, Vector3 end, float timeStartedLerp, float lerpTime = 1){
		float timeSinceStarted = Time.time - timeStartedLerping;
		float percentageComplete = timeSinceStarted / lerpTime;
		var result = Vector3.Lerp(start, end, percentageComplete);

		return result;
	}

    // Start is called before the first frame update
    public void Start()
    {
    	float startLevel = 0;

    	//startPosition.y = string.IsNullOrEmpty(StartY.text) ? 0 : Convert.ToSingle(StartY.text);  
    	startPosition.y = waterLevel.value;
    	startLevel = waterLevel.value;

    	endPosition.y = string.IsNullOrEmpty(Peak.text) ? startLevel : Convert.ToSingle(Peak.text);

    	startPosition = new Vector3(0, startPosition.y, 250);
    	endPosition = new Vector3(0, endPosition.y, 250);
    	lerpTime = string.IsNullOrEmpty(SetTime.text) ? 1 : Convert.ToSingle(SetTime.text);
        StartLerping();
    }

    // Update is called once per frame
    void Update(){
    	if (shouldLerp){
		transform.position = Lerp(startPosition, endPosition, timeStartedLerping, lerpTime);    		
    	}
    }

}
