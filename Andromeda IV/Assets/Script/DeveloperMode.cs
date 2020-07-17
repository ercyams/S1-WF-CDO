using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeveloperMode : MonoBehaviour{

	public GameObject DevTool;

	public void RestartGame(){
		SceneManager.LoadScene("Terrain");
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.R)){
        	Application.LoadLevel(0);     
		}

	    if(Input.GetKeyDown(KeyCode.D)){
            DevTool.SetActive(true);
        }

	}
}
