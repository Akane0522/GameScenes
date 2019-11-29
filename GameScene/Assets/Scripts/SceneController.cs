using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	private static int n;
	private static int m;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnClick1(){
		if(SceneManager.GetActiveScene().name == "Start"){
			SceneManager.LoadScene("MainMemu");
		}else if(SceneManager.GetActiveScene().name == "MainMemu"){
			SceneManager.LoadScene("StartTraning");
		}else if(SceneManager.GetActiveScene().name == "StartTraning"){
			SceneManager.LoadScene("EndTraning");
		}else if(SceneManager.GetActiveScene().name == "EndTraning"){
			SceneManager.LoadScene("MainMemu");
		}
		/*
		if(SceneManager.GetActiveScene().name == "Start"){
			SceneManager.LoadScene("MainMemu");
		}else if(SceneManager.GetActiveScene().name == "MainMemu"){
			SceneManager.LoadScene("SampleScene");
		}else if(SceneManager.GetActiveScene().name == "SampleScene"){
			SceneManager.LoadScene("StartTraning");
		}else if(SceneManager.GetActiveScene().name == "StartTraning"){
			SceneManager.LoadScene("EndTraning");
		}else if(SceneManager.GetActiveScene().name == "EndTraning"){
			SceneManager.LoadScene("MainMemu");
		}*/
	}

	public void OnClick2(){
		if(SceneManager.GetActiveScene().name == "StartTraning"){
			SceneManager.LoadScene("SelectHW");
		}else if(SceneManager.GetActiveScene().name == "SelectHW"){
			switch(transform.name){
				case "handout1":
					SceneManager.LoadScene("1ToSelectHint");
					break;
				case "handout2":
					SceneManager.LoadScene("2ToSelectHint");
					break;
				case "handout3":
					SceneManager.LoadScene("3ToSelectHint");
					break;
				default:
					break;
			}
		}
	}
	public void OnClick3(){
		if(SceneManager.GetActiveScene().name == "1ToSelectHint"){
			switch(transform.name){
				case "problem1":
					SceneManager.LoadScene("1toI");
					break;
				case "problem2":
					SceneManager.LoadScene("1toRo");
					break;
				case "problem3":
					SceneManager.LoadScene("1toHa");
					break;
				case "problem4":
					SceneManager.LoadScene("1toNi");
					break;
				case "problem5":
					SceneManager.LoadScene("1toHo");
					break;
				case "problem6":
					SceneManager.LoadScene("1toHe");
					break;
				case "problem7":
					SceneManager.LoadScene("1toTo");
					break;
				case "problem8":
					SceneManager.LoadScene("1toChi");
					break;
				case "problem9":
					SceneManager.LoadScene("1toRi");
					break;
				case "problem10":
					SceneManager.LoadScene("1toNu");
					break;
				default:
					break;
			}
		}
	}

	public void OnClick4(){
		if(SceneManager.GetActiveScene().name == "MainMemu"){
			SceneManager.LoadScene("Story");
		}else if(SceneManager.GetActiveScene().name == "LoseBattle"){
			SceneManager.LoadScene("MainMemu");
		}else if(SceneManager.GetActiveScene().name == "WinBattle"){
			SceneManager.LoadScene("MainMemu");
		}
	}

		public void InitOnClick(){
		if(SceneManager.GetActiveScene().name == "MainMemu"){
			SceneManager.LoadScene("InitScene");
		}else if(SceneManager.GetActiveScene().name == "InitScene"){
			SceneManager.LoadScene("MainMemu");
		}
	}
	
	public void BackOnClick(){
		if(SceneManager.GetActiveScene().name == "1ToSelectHint"){
			SceneManager.LoadScene("SelectHW");
		}else if(SceneManager.GetActiveScene().name == "SelectHW"){
			SceneManager.LoadScene("StartBattle");
		}
	}

	public void BackOnClick2(){
		SceneManager.LoadScene("1ToSelectHint");
	}

	public void BattleSceneOnClick(){
		
	}
	
}
