using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterLevel : MonoBehaviour {

	public GameObject waterLevel;
	
	public Text Area;
	public Text Velocity;
	public Text Coefficient;
	public Text Timer;

	public Text Result;	
	public Text WaterStage;
	public Text AlarmLevel;	
	public Text AlarmStatus;

	public void ProccessSimulation(){
		
			// Variable Declaration
			float totalFlow = 0.0F;
			float flowOverTime = 0.0F;
			double convertFlow = 0.0f;

			// Get Input Value
			float time = float.Parse(Timer.text);
			float area = float.Parse(Area.text);								
			float velocity = float.Parse(Velocity.text);
			float coefficient = 0.8F;	
			
			// Get Water Level
			Vector3 pos = waterLevel.transform.position;
			WaterStage.text = pos.y.ToString("####0.00") + " m";		
			pos.y += 0.3f * Time.deltaTime;
			waterLevel.transform.position = pos;
			if(pos.y <= 2){
				AlarmLevel.text = "20%";
				AlarmStatus.text = "Normal";
			}
			else if((pos.y > 2) && (pos.y <= 3.80)){
				AlarmLevel.text = "40%";
				AlarmStatus.text = "Alert";
			}else if((pos.y > 3.80) && (pos.y <= 5.25)){
				AlarmLevel.text = "60%";
				AlarmStatus.text = "Alarm";
			}else if((pos.y > 5.25) && (pos.y >= 6.61)){
				AlarmLevel.text = "80%";
				AlarmStatus.text = "Critical";
			}

			// Calculate Input
			totalFlow = area * velocity * coefficient;
			flowOverTime = totalFlow / 15;
			convertFlow = flowOverTime * 101.9406;

			Debug.Log(flowOverTime);
			Debug.Log(convertFlow);
			
			Result.text = convertFlow.ToString("####0.00") + " cms";


			// Alarm Status and Level
				// 5.75 - 100 Overflow
				// 4.61 - 80 critical
				// 3.25 - 60 Alarm
				// 1.80 - 40 alert
	} 

	public void SliderChanged(float newValue){

			// Slider 
			Vector3 pos = waterLevel.transform.position;
			pos.y = newValue;
			waterLevel.transform.position = pos;
	}


}
