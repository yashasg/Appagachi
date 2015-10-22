using UnityEngine;
using System.Collections;

public class EatClick : MonoBehaviour {

	// Update is called once per frame
	public UnityEngine.UI.Text totalCaloriesText;
	public GameObject Fish;
	private int consumedCalories;

	public void OnEat() {
		consumedCalories += Fish.GetComponent<DragItem> ().resultCalories;
		Fish.GetComponent<DragItem> ().reset ();
		totalCaloriesText.text = "Calories: " + consumedCalories + " / 1000" ;
	}
}
