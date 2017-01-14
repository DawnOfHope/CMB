using UnityEngine;
using System.Collections;

public class drawDate : MonoBehaviour {
	public int num=1;
	public UILabel dtNow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	private void drawDateNow(int firstDayofWeek,int endMonthDay, int year , int month){
		for (int i = 0; i < 6; i++) {
			for(int j=0;i<7;j++){
				if (i == 0 && j < firstDayofWeek) {
					continue;
				} else {
					if (num > endMonthDay) {
						break;
					}
					string cMonth = null;
					string cDay = null;
					string cHoliday = null;
					string ccHoliday = null;

					if (j > 0 && j < 6) {
					}
				}
		}
	}
}
