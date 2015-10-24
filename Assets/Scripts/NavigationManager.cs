using UnityEngine;
using System.Collections;

public class NavigationManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void loadMainScreen(){
		Application.LoadLevel (0);
	}
	public void loadLoginScreen(){
		Application.LoadLevel (1);
		
	}
	public void loadDrugEditorScreen(){
		Application.LoadLevel (2);

	}

	public void loadAccessoryScreen(){
		Application.LoadLevel (3);

	}

}
