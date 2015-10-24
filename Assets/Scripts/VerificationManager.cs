using UnityEngine;
using System.Collections;

public class VerificationManager : MonoBehaviour {
	public GameObject panel;
	//when the timer runs out on a pill
		//activate the overlay
		//make everything else unclickable (this might happen by just making the thing active)

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void hideOverlay(){
		panel.SetActive (false);
	}
	public void showOverlay(){
		panel.SetActive (true);

	}
}
