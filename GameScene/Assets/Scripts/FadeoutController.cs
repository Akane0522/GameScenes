using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeoutController : MonoBehaviour {

 float fadeSpeed = 0.02f;        //透明度が変わるスピードを管理
	float red, green, blue, alfa;   //パネルの色、不透明度を管理
 
	Image fadeImage;                //透明度を変更するパネルのイメージ

	float TimeCount;

	bool SceneFlag = false;
 
	void Start () {
		fadeImage = GetComponent<Image> ();
		red = fadeImage.color.r;
		green = fadeImage.color.g;
		blue = fadeImage.color.b;
		alfa = fadeImage.color.a;

		TimeCount　= 4.5f;
	}
 
	void Update () {
		TimeCount -= Time.deltaTime;

   		if(TimeCount <= 0){
			StartFadeOut ();

			if(SceneFlag){
				SceneManager.LoadScene("StartBattle");
			}
        }
	}
 
	void StartFadeOut(){
		fadeImage.enabled = true;  // a)パネルの表示をオンにする
		alfa += fadeSpeed;         // b)不透明度を徐々にあげる
		SetAlpha ();               // c)変更した透明度をパネルに反映する
		if(alfa >= 1){             // d)完全に不透明になったら処理を抜ける
			SceneFlag = true;
		}
	}
 
	void SetAlpha(){
		fadeImage.color = new Color(red, green, blue, alfa);
	}
}
