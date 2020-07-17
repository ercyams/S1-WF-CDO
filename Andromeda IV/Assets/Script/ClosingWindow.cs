using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
	
public class ClosingWindow : MonoBehaviour
{

	public GameObject Map;
	public GameObject Information;
	public GameObject Simulation;
    public GameObject Discharge;
    public GameObject Flow;
    public GameObject DataGraph;
    public GameObject Result;
    public GameObject ResultPanel;
    public GameObject Close;
    public GameObject PeakDischarge;
    public GameObject Simulate;
    public GameObject DevTool;

    public void onClickDevTool(){
         if (DevTool.activeInHierarchy){
             DevTool.SetActive(false);
         }else{
             DevTool.SetActive(true);
         }
    }

    public void onClickSimulation(){
         if (Simulate.activeInHierarchy){
             Simulate.SetActive(false);
         }else{
             Simulate.SetActive(true);
         }
    }

    public void onClickClose(){
         if (Close.activeInHierarchy){
             Close.SetActive(false);
         }else{
             Close.SetActive(true);
         }
    }

    public void onClickPeakDischarge(){
         if (PeakDischarge.activeInHierarchy){
             PeakDischarge.SetActive(false);
         }else{
             PeakDischarge.SetActive(true);
         }
    }

    public void onClickResultPanel(){
         if (ResultPanel.activeInHierarchy){
             ResultPanel.SetActive(false);
         }else{
             ResultPanel.SetActive(true);
         }
    }

    public void onClickData(){
         if (DataGraph.activeInHierarchy){
             DataGraph.SetActive(false);
         }else{
             DataGraph.SetActive(true);
         }
    }

    public void onClickDischarge(){
         if (Discharge.activeInHierarchy){
             Discharge.SetActive(false);
         }else{
             Discharge.SetActive(true);
         }
    }

    public void onClickFlow(){
         if (Flow.activeInHierarchy){
             Flow.SetActive(false);
         }else{
             Flow.SetActive(true);
         }
    }

	public void onClickMap(){
         if (Map.activeInHierarchy){
             Map.SetActive(false);
         }else{
             Map.SetActive(true);
         }
    }

	public void onClickInfo(){
         if (Information.activeInHierarchy){
             Information.SetActive(false);
         }else{
             Information.SetActive(true);
         }
    }

	public void onClickSimulate(){
         if (Simulation.activeInHierarchy){
             Simulation.SetActive(false);
         }else{
             Simulation.SetActive(true);
         }
    }

    public void onClickResults(){
         if (Result.activeInHierarchy){
             Result.SetActive(false);
         }else{
             Result.SetActive(true);
         }
    }

}
