using UnityEngine;
using System.Collections;

public class DragItem : MonoBehaviour {

	public UnityEngine.UI.Text multiplierText;
	public UnityEngine.UI.Text multplierResultText;
	public int calories;

	private int multiplier;
	public int resultCalories;
	// Use this for initialization
	void Start () {
		multiplier = 0;
		multplierResultText.text = "";
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown() {
		multiplier++;
		multiplierText.text = "x " + multiplier;
		resultCalories = calories * multiplier;
		multplierResultText.text = " = " + resultCalories;
	}

	public void reset() {
		multiplier = 0;
		multplierResultText.text = "";
		multiplierText.text = "x 0";
		resultCalories = 0;
	}
}
