using UnityEngine;
using System.Collections;

public class EatClick : MonoBehaviour {

	// Update is called once per frame
	public UnityEngine.UI.Text totalCaloriesText;
    public UnityEngine.UI.Slider happinessSlider;
	public GameObject Fish;
	private int consumedCalories;

	public void OnEat() {

        happinessSlider.value += 10;
        
        /*consumedCalories += Fish.GetComponent<DragItem> ().resultCalories;
		Fish.GetComponent<DragItem> ().reset ();
		totalCaloriesText.text = "Calories: " + consumedCalories + " / 1000" ;*/

	}
}
