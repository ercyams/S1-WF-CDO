using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchBehaviour : MonoBehaviour
{
	public GameObject switchOn;
	public GameObject switchOff;

	public void onChangeValue(){
		bool onoffSwitch = gameObject.GetComponent<Toggle>().isOn;
		if(onoffSwitch){
			switchOn.SetActive(true);
			switchOff.SetActive(false);
		}
		if(!onoffSwitch){
			switchOn.SetActive(false);
			switchOff.SetActive(true);			
		}

	}

}
