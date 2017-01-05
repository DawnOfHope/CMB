using UnityEngine;
using System.Collections;

public class loadingEvent : MonoBehaviour {

	public GameObject Panel;


	void Start () {
		UIEventListener.Get (Panel).onClick = onPanelClick;
		Debug.Log ("back");
	
	}
	
	//Loading temporary events
	void onPanelClick(GameObject Panel){		
		Debug.Log("ClickBack");
		Application.LoadLevel (1);
	}
}
