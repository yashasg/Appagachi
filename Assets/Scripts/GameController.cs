using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	int points;


	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
	
	}
	public void setPointCount(int i_points){
		points = i_points;
	}
	public int getPointCount(){
		return points;
	}
	public void increasePointCount(){
		points++;
	}
	public void decreasePointCount(){
		points--;
	}
	public void updatePointsLabel(){

	}
}
