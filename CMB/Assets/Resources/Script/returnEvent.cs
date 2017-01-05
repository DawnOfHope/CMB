using UnityEngine;
using System.Collections;

public class returnEvent : MonoBehaviour {

	public GameObject btnReturn1;


	void Start () {
		UIEventListener.Get (btnReturn1).onClick = onBtnReturn1Click;

	}

	//Loading temporary events
	void onBtnReturn1Click(GameObject btnReturn1){		
		Debug.Log("ClickBack");
		Application.LoadLevel (1);
	}
}
