using UnityEngine;
using System.Collections;

public class EatClick : MonoBehaviour {

	// Update is called once per frame
	public PillDrop PD;
	public UnityEngine.UI.Text totalCaloriesText;
    public UnityEngine.UI.Slider happinessSlider;
	public GameObject Fish;
	private int consumedCalories;

	public void start(){
		PD = GetComponent<PillDrop> ();
	}

	public void OnEat() {

        happinessSlider.value += 10;
		PD.activate = true;
        
        /*consumedCalories += Fish.GetComponent<DragItem> ().resultCalories;
		Fish.GetComponent<DragItem> ().reset ();
		totalCaloriesText.text = "Calories: " + consumedCalories + " / 1000" ;*/

	}
}
