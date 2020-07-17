using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;
using System.Linq;
using System;

public class Graph : MonoBehaviour{

	public float[] normalFlow;

	public Text Day1;
	public Text Day2;
	public Text Day3;
	public Text Day4;
	public Text Day5;
	public Text Day6;
	public Text Day7;

	public Text Mean;
	public Text Mode;
	public Text StandardDeviation;


	[SerializeField] private Sprite circleSprite;
	private RectTransform graphContainer;
	private RectTransform labelTemplateX;
	private RectTransform labelTemplateY;	
    private RectTransform dashTemplateX;
    private RectTransform dashTemplateY;

	public void Awake(){
		graphContainer = transform.Find("graphContainer").GetComponent<RectTransform>();
		labelTemplateX = graphContainer.Find("labelTemplateX").GetComponent<RectTransform>();
		labelTemplateY = graphContainer.Find("labelTemplateY").GetComponent<RectTransform>();
        dashTemplateY = graphContainer.Find("dashTemplateX").GetComponent<RectTransform>();
        dashTemplateX = graphContainer.Find("dashTemplateY").GetComponent<RectTransform>();


        normalFlow = new float[7];
        normalFlow[0] = float.Parse(Day1.text);
        normalFlow[1] = float.Parse(Day2.text);
        normalFlow[2] = float.Parse(Day3.text);
        normalFlow[3] = float.Parse(Day4.text);
        normalFlow[4] = float.Parse(Day5.text);
        normalFlow[5] = float.Parse(Day6.text);
        normalFlow[6] = float.Parse(Day7.text);


		var mode = normalFlow.GroupBy(n=> n).
		    OrderByDescending(g=> g.Count()).
		    Select(g => g.Key).FirstOrDefault();
		
		Debug.Log("mode: " + mode);

		double average = normalFlow.Average();
		double sumOfSquaresOfDifferences = normalFlow.Select(val => (val - average) * (val - average)).Sum();
		double sd = Math.Sqrt(sumOfSquaresOfDifferences / normalFlow.Length); 

		Mean.text = average.ToString("####0.00") + " cu.m./sec.";
		Mode.text = mode.ToString("####0.00") + " cu.m./sec.";
		StandardDeviation.text = sd.ToString("####0.00") + " cu.m./sec.";

		Debug.Log("average: " + average);
		Debug.Log("sumOfSquaresOfDifferences: " + sumOfSquaresOfDifferences);
		Debug.Log("sd: " + sd);

		List<float> valueList = new List<float>() {normalFlow[0],normalFlow[1],normalFlow[2],normalFlow[3],normalFlow[4],normalFlow[5],normalFlow[6]};
		ShowGraph(valueList);
	}

	private GameObject CreateCircle(Vector2 anchoredPosition){
		GameObject gameObject = new GameObject("circle", typeof(Image));
		gameObject.transform.SetParent(graphContainer, false);
		gameObject.GetComponent<Image>().sprite = circleSprite; 
		RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
		rectTransform.anchoredPosition = anchoredPosition;
		rectTransform.sizeDelta = new Vector2(11, 11);
		rectTransform.anchorMin = new Vector2(0, 0);
		rectTransform.anchorMax = new Vector2(0, 0);
		return gameObject;
	}

	private void ShowGraph(List<float> valueList){
		float graphHeight = graphContainer.sizeDelta.y;
		float yMaximum = 100f;
		float xSize = 50f;
		GameObject lastCircleGameObject = null;
		for(int i = 0; i < valueList.Count; i++){
			float xPosition = xSize + i * xSize;
			float yPosition = (valueList[i] / yMaximum) * graphHeight;
			GameObject circleGameObject = CreateCircle(new Vector2(xPosition,yPosition));
			if (lastCircleGameObject != null){
				CreateDotConnection(lastCircleGameObject.GetComponent<RectTransform>().anchoredPosition,circleGameObject.GetComponent<RectTransform>().anchoredPosition);
			}
			lastCircleGameObject = circleGameObject;

			RectTransform labelX = Instantiate(labelTemplateX);
			labelX.SetParent(graphContainer, false);
			labelX.gameObject.SetActive(true);
			labelX.anchoredPosition = new Vector2(xPosition, -5f);
			int fixLabelX = i + 1;
			labelX.GetComponent<Text>().text = fixLabelX.ToString();


            RectTransform dashX = Instantiate(dashTemplateX);
            dashX.SetParent(graphContainer, false);
            dashX.gameObject.SetActive(true);
            dashX.anchoredPosition = new Vector2(xPosition, -1f);
		}

		int separatorCount = 10;
		for (int i=0; i <= separatorCount; i++){
			RectTransform labelY = Instantiate(labelTemplateY);
			labelY.SetParent(graphContainer, false);
			labelY.gameObject.SetActive(true);
			float normalizedValue = i * 1f / separatorCount;
			labelY.anchoredPosition = new Vector2(-5f, normalizedValue * graphHeight);
			labelY.GetComponent<Text>().text = Mathf.RoundToInt(normalizedValue * yMaximum).ToString();

			RectTransform dashY = Instantiate(dashTemplateY);
            dashY.SetParent(graphContainer, false);
            dashY.gameObject.SetActive(true);
            dashY.anchoredPosition = new Vector2(-4f, normalizedValue * graphHeight);
		}
	}

	private void CreateDotConnection(Vector2 dotPositionA, Vector2 dotPositionB){
		GameObject gameObject = new GameObject("dotConnection", typeof(Image));
		gameObject.transform.SetParent(graphContainer, false);
		gameObject.GetComponent<Image>().color = new Color(1,1,1, .5f);
		RectTransform rectTransform = gameObject.GetComponent<RectTransform>();
		Vector2 dir = (dotPositionB - dotPositionA).normalized;
		float distance = Vector2.Distance(dotPositionA, dotPositionB);
		rectTransform.anchorMin = new Vector2(0,0);
		rectTransform.anchorMax = new Vector2(0,0);
		rectTransform.sizeDelta = new Vector2(distance,3f);
		rectTransform.anchoredPosition = dotPositionA + dir * distance * .5f;
		rectTransform.localEulerAngles = new Vector3(0,0, UtilsClass.GetAngleFromVectorFloat(dir));
	}
}
