using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BattleResult : MonoBehaviour {

	//自分のレベル
	int mylevel;

	//敵のレベル
	int enemylevel;

	//自分のレベルの読み込み用
	string[] MyText = new string[20]; 

	//敵のレベルの読み込み用
	string[] EnemyText = new string[20]; //読み込み用

	//敵のレベルの書き出し用
	string[] enemytext = new string[20]; //書き出し用

	// Use this for initialization
	void Start () {
		Textread();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Textread(){
        MyText = File.ReadAllLines(Application.dataPath + "/Assets/chardata.txt");
        mylevel = int.Parse(MyText[0]);

		EnemyText = File.ReadAllLines(Application.dataPath + "/Assets/enemydata.txt");
        enemylevel = int.Parse(EnemyText[0]);
    }

	public void CompareLevel(){
		if(mylevel > enemylevel){
			SceneManager.LoadScene("WinBattle");
			enemylevel = enemylevel + 2;
			enemytext[0] = enemylevel.ToString();
        	File.WriteAllLines(Application.dataPath + "/Assets/enemydata.txt", enemytext);
		}else{
			SceneManager.LoadScene("LoseBattle");
		}
	}

	public void InitOnClick(){
		enemylevel = 1;
		enemytext[0] = enemylevel.ToString();
        File.WriteAllLines(Application.dataPath + "/Assets/enemydata.txt", enemytext);

	}
}
