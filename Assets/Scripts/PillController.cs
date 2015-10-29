using UnityEngine;
using System.Collections;

public class PillController : MonoBehaviour
{

    float fTimer;
    float fCountDownTime;
	//public GameObject PinPanel;
	public GameObject character;

    public class PillData
    {
        public string name;
        public string frequency;
        public int dosage;

        public PillData(string i_name, string i_frequency, int i_dosage)
        {
            name = i_name;
            frequency = i_frequency;
            dosage = i_dosage;
        }
    }

    public PillData data;
    string initialTime;
    public UnityEngine.UI.Text timerText;
    public UnityEngine.UI.Text nameText;

    private int startTime;

    // Use this for initialization
    void Start()
    {
        float fMinutes, fSeconds;
		if (data == null) {
			data = new PillData("asd", "00:15", 3);
		}
        initialTime = data.frequency;
       // initialTime = "0:10";

        nameText.text = data.name;
        string[] sTimeUnits = initialTime.Split(":".ToCharArray());
        if (float.TryParse(sTimeUnits[0], out fMinutes) && float.TryParse(sTimeUnits[1], out fSeconds))
        {
          //  fSeconds = 10;
            fMinutes *= 60;
            fTimer = fMinutes + fSeconds;
            fCountDownTime = fTimer;
            Debug.Log("In Start" + string.Format("Timer=" + timerText));
        }
    }

    // Update is called once per frame
    void Update()
    {
        //PinPanel.SetActive(true);
        //Debug.Log(fTimer);
        if (fTimer > 0)
        {

            //enabled = false;
            timerText.color = Color.white;
            fTimer = fTimer - Time.deltaTime;
            int roundedRestSeconds = Mathf.CeilToInt(fTimer);
            int iRemMin = (int)(roundedRestSeconds / 60);
            int iRemSec = (int)(roundedRestSeconds % 60);
            //fTimer/60;
            timerText.text = string.Format("{0:00}:{1:00}", iRemMin, iRemSec);
            //Debug.Log("Mins "+iRemMin+"Secs "+iRemSec);
            //Debug.Log(fTimer);

        }
        if (fTimer <= 0f)
        {
            timerText.color = Color.red;
            fTimer = 60*60;
            if (!PillListController.timerPanel.activeSelf)
            {
                PillListController.timerPanel.SetActive(true);
            }
			AnimationManager.Instance.AnimateSad();
			//anim.setTrigger("sad");

            //Debug.Log("");
            //PinPanel.gameObject.SetActive(true);
            //PinPanel.SetActive(true);
            //Debug.Log(PinPanel.activeSelf);
            //enabled = true;
        }
    }

    public void resetTimer()
    {
        Animator anim = PillListController.character.GetComponent<Animator>();
        anim.SetTrigger("sad");
    }
}
