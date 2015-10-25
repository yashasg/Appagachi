using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
    float fTimer = 10;
    bool TimerStart;
    public UnityEngine.UI.Text lTimer;
    public UnityEngine.UI.Button bPill1;
    Vector2 boxSpawnPosition;

	// Use this for initialization
	void Start () {
        boxSpawnPosition=bPill1.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (fTimer > 0)
        {
            fTimer -= Time.deltaTime;
            lTimer.text = fTimer.ToString("0");
        }
        if (fTimer <= 0f)
        {
           // Application.LoadLevel()
        }
	}
}
