using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SliderManager : MonoBehaviour {

    public Slider slider;// = GetComponent<Slider>();


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void test() {

    }

    public void IncreaseHappinessMeter()
    {
           slider.value++;
      //  gameobject.value++;

    }
}
