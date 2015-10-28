using UnityEngine;
using System.Collections;

public class DisplaypPinInput : MonoBehaviour {

	public PillDrop PD;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void panelActive(GameObject pPinInput)
	{	pPinInput.SetActive(true);
    }
	public void panelInactive(GameObject pPinInput)
	{
		pPinInput.SetActive(false);
		PD.activate = true;
	}


}
