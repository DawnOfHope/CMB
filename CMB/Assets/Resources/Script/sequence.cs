using UnityEngine;
using System.Collections;

public class sequence : MonoBehaviour {
	public GameObject[] arrayMonth;
	public GameObject m1,m2,m3,m4,m5,m6,m7,m8,m9,m10,m11,m12;
	

	// Use this for initialization
	void Awake(){
		
		for (int i = 0; i < 6; i++) {
			AutomaticSorting();
		}

		arrayMonth = new GameObject[] {
			m1 = Instantiate(Resources.Load("ResDATA/monthLab/1")) as GameObject,
			m2 = Instantiate(Resources.Load("ResDATA/monthLab/2")) as GameObject,
			m3 = Instantiate(Resources.Load("ResDATA/monthLab/3")) as GameObject,
			m4 = Instantiate(Resources.Load("ResDATA/monthLab/4")) as GameObject,
			m5 = Instantiate(Resources.Load("ResDATA/monthLab/5")) as GameObject,
			m6 = Instantiate(Resources.Load("ResDATA/monthLab/6")) as GameObject,
			m7 = Instantiate(Resources.Load("ResDATA/monthLab/7")) as GameObject,
			m8 = Instantiate(Resources.Load("ResDATA/monthLab/8")) as GameObject,
			m9 = Instantiate(Resources.Load("ResDATA/monthLab/9")) as GameObject,
			m10 = Instantiate(Resources.Load("ResDATA/monthLab/10")) as GameObject,
			m11 = Instantiate(Resources.Load("ResDATA/monthLab/11")) as GameObject,
			m12 = Instantiate(Resources.Load("ResDATA/monthLab/12")) as GameObject,
		};


	
	}
	public void AutomaticSorting(){
		GameObject a1 = Instantiate (Resources.Load ("ResDATA/Month1")) as GameObject;
		a1.transform.SetParent (transform, false);


	}

	void CallMonthLab(){
		GameObject a2 = Instantiate (Resources.Load("ResDATA/Month1")) as GameObject;
		int i = Random.Range (0,arrayMonth.Length);
//		arrayMonth.transform.position = arrayMonth [i].transform.position;
	}


}
