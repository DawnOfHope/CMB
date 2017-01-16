using UnityEngine;
using System.Collections;

public class yearTime : MonoBehaviour {
	public UILabel labY;

	// Use this for initialization
	void Start () {
		labY.text = System.DateTime.Now.ToString ("yyyy");


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
