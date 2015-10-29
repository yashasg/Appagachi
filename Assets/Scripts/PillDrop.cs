using UnityEngine;
using System.Collections;

public class PillDrop : MonoBehaviour {

	public UnityEngine.UI.Image pImage;
	public UnityEngine.UI.Button bDone;
	Vector3 temp;
	Vector3 temp1;
	public bool activate = false;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		if (activate == true)
		{
			Pill_Drop ();
		}

	}
	public void Pill_Drop()
	{
		temp = pImage.transform.position;
		temp.y = temp.y - 0.01f;
		temp1 = pImage.transform.eulerAngles;
		pImage.transform.localEulerAngles = new Vector3 (temp1.x, temp1.y, temp1.z);
		pImage.transform.position = new Vector3 (temp.x, temp.y, temp.z);
		pImage.transform.Rotate (new Vector3 (pImage.transform.eulerAngles.x, pImage.transform.eulerAngles.y, (pImage.transform.eulerAngles.z - 05)*Time.deltaTime*2));
		Debug.Log("temp " + temp.y);
		Debug.Log("pImage.GetComponent<RectTransform>().position.y " + pImage.GetComponent<RectTransform>().position.y);

		if (pImage.GetComponent<RectTransform>().position.y <= 1.78f) 
		{
			pImage.gameObject.SetActive(false); 
		}
	}
}