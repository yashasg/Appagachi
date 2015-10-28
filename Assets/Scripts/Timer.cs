using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
    float fTimer;
    public UnityEngine.UI.Text lTimer;
    public UnityEngine.UI.Button bPill1;
	public UnityEngine.UI.Text bPillName;
	string initialTime;

	// Use this for initialization
	void Start () {
		float fMinutes,fSeconds;
		initialTime = lTimer.text;
		string[] sTimeUnits=initialTime.Split (":".ToCharArray());
		if (float.TryParse (sTimeUnits [0], out fMinutes)&& float.TryParse(sTimeUnits [1],out fSeconds )) {
			fMinutes*=60;
			fTimer=fMinutes+fSeconds;
			//Debug.Log("In Start"+string.Format("Timer="+fTimer));
		}
    }
	
	// Update is called once per frame
	void Update () {





        if (fTimer > 0)
		{	bPill1.enabled=false;
			fTimer=fTimer-Time.deltaTime;
			int roundedRestSeconds = Mathf.CeilToInt(fTimer);
			int iRemMin=(int)(roundedRestSeconds/60);
			int iRemSec=(int)(roundedRestSeconds%60);
			//fTimer/60;
			lTimer.text = string.Format("{0:00}:{1:00}",iRemMin,iRemSec);
			//Debug.Log("Mins "+iRemMin+"Secs "+iRemSec);

        }
        if (fTimer <= 0f)
		{
			lTimer.color=Color.red;
			bPill1.enabled=true;
        }
	}
}
