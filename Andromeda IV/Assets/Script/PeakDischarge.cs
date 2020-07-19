using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PeakDischarge : MonoBehaviour
{

	public Text Coefficient;
	public Text Intensity;
	public Text Area;
	public InputField Discharge;
	

	public void Calculate(){

		float coefficient = float.Parse(Coefficient.text);
		float intensity = float.Parse(Intensity.text);
		float area = float.Parse(Area.text);
		float result = 0.0f;
		double convertFloat = 0.0f;

		result = coefficient * intensity * area;
		convertFloat = result* 101.9406;
		Discharge.text = convertFloat.ToString("####0.00") + " m3/s"; 
	}
}
