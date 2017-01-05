using UnityEngine;
using System.Collections;

public class btnClick : MonoBehaviour {
	public GameObject btnCalender, btnCall, btnMap, btnSetting;

	// Use this for initialization
	void Start () {
		UIEventListener.Get(btnCalender).onClick = onBtnCalenderClick;
		UIEventListener.Get(btnCall).onClick = onBtnCallClick;
		UIEventListener.Get(btnMap).onClick = onBtnMapClick;
		UIEventListener.Get(btnSetting).onClick = onBtnSettingClick;
	
	}
	
	// Update is called once per frame
	void onBtnCalenderClick(GameObject btnCalender){
		Application.LoadLevel (2);
	}
	void onBtnCallClick(GameObject btnCall){
		Application.LoadLevel (3);
	}
	void onBtnMapClick(GameObject btnMap){
		Application.LoadLevel (4);
	}
	void onBtnSettingClick(GameObject btnSetting){
		Application.LoadLevel (5);
	}
}
