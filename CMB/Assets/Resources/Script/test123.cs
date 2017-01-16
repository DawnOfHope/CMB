using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
using System.Linq; 

public class test123 : MonoBehaviour {
	public UILabel labM,labD;
	public int yest1;

	public int yearNum,monNum,dayNum;


	// Use this for initialization
	void Start () {

		for (int i = 1; i <= 12; i++) {
			yest1 = i;
			Debug.Log (yest1);
			labM.text = yest1.ToString();

		}




//		labM.text = System.DateTime.Now.ToString ("MM");
//		labD.text = System.DateTime.Now.ToString ("dd");
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
	
	}
}
