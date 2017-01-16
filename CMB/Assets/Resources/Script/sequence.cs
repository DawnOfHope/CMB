using UnityEngine;
using System.Collections;

public class sequence : MonoBehaviour {
	

	// Use this for initialization
	void Awake(){
		
		
		for (int i = 0; i < 6; i++) {
			
			automaticSorting();
		}


	
	}
	public void automaticSorting(){
		GameObject a1 = Instantiate (Resources.Load ("ResDATA/Month1")) as GameObject;
		a1.transform.SetParent (transform, false);



	}


}
