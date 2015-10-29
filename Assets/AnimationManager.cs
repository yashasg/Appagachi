using UnityEngine;
using System.Collections;



public class AnimationManager : MonoBehaviour {
    Animator anim;
   // public UnityEngine.UI.Slider slider; 
	private static AnimationManager __instance;

	public static AnimationManager Instance
	{
		 
		get{
			if(__instance == null){
			__instance = FindObjectOfType<AnimationManager>();
			}
			return __instance;
		}
	}
    void Start()
    {
        anim = GetComponent<Animator>();
        //slider = GameObject.Find("sHappinessMeter");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AnimateHappyDance()
    { //for sad fox tail position
        anim.SetTrigger("hiphop");

    }
    public void AnimateSad()
    { //for sad fox tail position
        anim.SetTrigger("sad");

    }
    public void AnimateBreakDance()
    { //for sad fox tail position
        anim.SetTrigger("breakdance");

    }
    public void AnimateIdle()
    {
        //for sad fox tail position
        anim.SetTrigger("idle");

    }
	public void AnimateExcited()
	{
		//for sad fox tail position
		anim.SetTrigger("excited");
		
	}
}
