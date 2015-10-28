using UnityEngine;
using System.Collections;

public class PillListController : MonoBehaviour
{

    public GameObject pillContentPanel;
    public GameObject pillPanel;
    public static GameObject timerPanel;
    public static GameObject character;

    public UnityEngine.UI.InputField pillNameText;
    public UnityEngine.UI.InputField pillFrequencyText;
    public UnityEngine.UI.InputField pillDosageText;

    // Use this for initialization
    void Start()
    {
        timerPanel = GameObject.Find("TimerPanel");
        character = GameObject.Find("Character");
        timerPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddPill()
    {
        string name = "";
        string frequency = "";
        int dosage = 0;

        if (pillNameText != null)
            name = pillNameText.textComponent.text;
        if (pillFrequencyText != null)
            frequency = pillFrequencyText.textComponent.text;
        if (pillDosageText != null)
            dosage = int.Parse(pillDosageText.textComponent.text);

        GameObject pill = Instantiate(pillPanel) as GameObject;

        PillController controller = pill.GetComponent<PillController>();
        controller.data = new PillController.PillData(name, frequency, dosage);

        pill.transform.SetParent(pillContentPanel.transform);
        pill.transform.localScale = Vector3.one;

    }
}
