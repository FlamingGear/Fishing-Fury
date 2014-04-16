using UnityEngine;
using System.Collections;

public class TimeText : MonoBehaviour {
	
	public GUIText timeText;
	// Countdown Timer
	public float timer = 5f;
	
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		
		timeText.text = "Time" + timer.ToString("0"); 
		
		if (timer <= 0) 
		{
			Application.LoadLevel("TripResults");
		}
	}
}
