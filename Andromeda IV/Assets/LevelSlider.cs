using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelSlider : MonoBehaviour
{

	Text updateText;
    // Start is called before the first frame update
    void Start()
    {
        updateText = GetComponent<Text> ();
    }

    // Update is called once per frame
    public void textUpdate(float value)
    {
        updateText.text = Mathf.Round(value * 100f) / 100f + " m";
    }
}
