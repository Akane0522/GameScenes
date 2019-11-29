using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ExpText : MonoBehaviour {

	Slider ExpSlider = null;
    //Textオブジェクト
	public GameObject level_object;
	Text levelnum_text;
	public int level;
	float maxExp = 200f;
    float nowExp;

	string[] AllText = new string[20]; //読み込み用
    string[] alltext = new string[20]; //書き出し用


	// Use this for initialization
	void Start () {

		ExpSlider = GetComponent<Slider>();

		if(System.IO.File.Exists(Application.dataPath + "/Assets/chardata.txt")){
			Textread();
		}else{
			File.CreateText(Application.dataPath + "/Assets/chardata.txt");
			InitOnClick();
			Textread();
		}

        //スライダーの最大値の設定
        ExpSlider.maxValue = maxExp;

        //スライダーの現在値の設定
        ExpSlider.value = nowExp;

		// オブジェクトからTextコンポーネントを取得
    	levelnum_text = level_object.GetComponent<Text> ();
				
	}
	
	// Update is called once per frame
	void Update () {

		nowExp = ExpSlider.value;
		levelnum_text.text = "" + level;
	}

	void Textread(){
        AllText = File.ReadAllLines(Application.dataPath + "/Assets/chardata.txt");
        level = int.Parse(AllText[0]);
        nowExp = float.Parse(AllText[1]);
    }

	public void OnClick(){
		nowExp += 60.0f;

		if(nowExp >= maxExp) {
			level++;
			nowExp = nowExp - maxExp;
		} 

		alltext[0] = level.ToString();
        alltext[1] = nowExp.ToString();
        File.WriteAllLines(Application.dataPath + "/Assets/chardata.txt", alltext);

	}
	public void OnClick1(){
		nowExp += 120.0f;

		if(nowExp >= maxExp) {
			level++;
			nowExp = nowExp - maxExp;
		} 

		alltext[0] = level.ToString();
        alltext[1] = nowExp.ToString();
        File.WriteAllLines(Application.dataPath + "/Assets/chardata.txt", alltext);

	}

	public void InitOnClick(){
		
		level = 0;
		nowExp = 0.0f;

		alltext[0] = level.ToString();
        alltext[1] = nowExp.ToString();
        File.WriteAllLines(Application.dataPath + "/Assets/chardata.txt", alltext);
	}
}
