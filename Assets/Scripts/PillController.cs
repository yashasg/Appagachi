using UnityEngine;
using System.Collections;

public class PillController : MonoBehaviour
{

    float fTimer;
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
        initialTime = data.frequency;
        nameText.text = data.name;
        string[] sTimeUnits = initialTime.Split(":".ToCharArray());
        if (float.TryParse(sTimeUnits[0], out fMinutes) && float.TryParse(sTimeUnits[1], out fSeconds))
        {
            fMinutes *= 60;
            fTimer = fMinutes + fSeconds;
            Debug.Log("In Start" + string.Format("Timer=" + timerText));
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(fTimer);
        if (fTimer > 0)
        {

            //enabled = false;
            fTimer = fTimer - Time.deltaTime;
            int roundedRestSeconds = Mathf.CeilToInt(fTimer);
            int iRemMin = (int)(roundedRestSeconds / 60);
            int iRemSec = (int)(roundedRestSeconds % 60);
            //fTimer/60;
            timerText.text = string.Format("{0:00}:{1:00}", iRemMin, iRemSec);
            Debug.Log("Mins "+iRemMin+"Secs "+iRemSec);
            Debug.Log(fTimer);

        }
        if (fTimer <= 0f)
        {
            timerText.color = Color.red;
            //enabled = true;
        };
    }
}
