using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InteractiveList : MonoBehaviour
{
	// public GameObject ItemTemplate;
	// public GameObject Content;

	// public void onClickAdd(){
	// 	var copy = Instantiate(ItemTemplate);
	// 	copy.transform.parent = Content.transform;
	// }

	// public GameObject[] deck;
	// public GameObject[] instanciatedObject;

	// public void Update(){
	// 	Fill();
	// }

	// public void Fill(){
	// 	instanciatedObject = new GameObject[deck.Length];
	// 	for(int i = 0; i < deck.Length; i++){
	// 		instanciatedObject[i] = Instantiate(deck[i]) as GameObject;
	// 	}
	// }

	public GameObject Day1;
    public GameObject Day2;
    public GameObject Day3;
    public GameObject Day4;
    public GameObject Day5;
    public GameObject Day6;
    public GameObject Day7;

    public void onClickDay1(){
         if (Day1.activeInHierarchy){
             Day1.SetActive(false);
         }else{
             Day1.SetActive(true);
         }
    }
    public void onClickDay2(){
         if (Day2.activeInHierarchy){
             Day2.SetActive(false);
         }else{
             Day2.SetActive(true);
         }
    }
    public void onClickDay3(){
         if (Day3.activeInHierarchy){
             Day3.SetActive(false);
         }else{
             Day3.SetActive(true);
         }
    }
    public void onClickDay4(){
         if (Day4.activeInHierarchy){
             Day4.SetActive(false);
         }else{
             Day4.SetActive(true);
         }
    }    
    public void onClickDay5(){
         if (Day5.activeInHierarchy){
             Day5.SetActive(false);
         }else{
             Day5.SetActive(true);
         }
    }
    public void onClickDay6(){
         if (Day6.activeInHierarchy){
             Day6.SetActive(false);
         }else{
             Day6.SetActive(true);
         }
    }
    public void onClickDay7(){
         if (Day7.activeInHierarchy){
             Day7.SetActive(false);
         }else{
             Day7.SetActive(true);
         }
    }
}
