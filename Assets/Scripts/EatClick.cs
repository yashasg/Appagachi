using UnityEngine;
using System.Collections;

public class EatClick : MonoBehaviour {

	// Update is called once per frame
	public PillDrop PD;
	public UnityEngine.UI.Text totalCaloriesText;
    public UnityEngine.UI.Slider happinessSlider;
	public UnityEngine.UI.Text Score;
	private int consumedCalories;

	public void start(){
		PD = GetComponent<PillDrop> ();
	}

	public void OnEat() {

        happinessSlider.value += 10;
		PD.activate = true;
		Score.text = "Score: 25";
        
        /*consumedCalories += Fish.GetComponent<DragItem> ().resultCalories;
		Fish.GetComponent<DragItem> ().reset ();
		totalCaloriesText.text = "Calories: " + consumedCalories + " / 1000" ;*/

	}
	public void setScoreTo0(){
		if(Score.text.Equals("Score: 25"))
		Score.text = "Score: 0";
	}

}
