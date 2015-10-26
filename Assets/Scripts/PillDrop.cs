using UnityEngine;
using System.Collections;

public class PillDrop : MonoBehaviour {

	public UnityEngine.UI.Image pImage;
	public UnityEngine.UI.Button bDone;
	Vector3 temp;
	public bool activate = false;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		if (activate == true) {
			Pill_Drop ();
		}

	}
	public void Pill_Drop(){
			temp = pImage.transform.position;
			temp.y = temp.y - 0.01f;
			pImage.transform.position = new Vector3 (temp.x, temp.y, temp.z);
			if (pImage.transform.position.y == 200f) {
				pImage.gameObject.SetActive (false);
			}
	}
}