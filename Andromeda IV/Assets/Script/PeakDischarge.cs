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
		float result = 0;

		result = coefficient * intensity * area;
		Discharge.text = result.ToString("####0.00") + " ft3/s (cfs)"; 
	}
}
