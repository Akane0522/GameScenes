using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cmmand : MonoBehaviour {

    //private
    private Image image;

	private Text text;

    private float time;

    private enum ObjType{
        TEXT,
        IMAGE
    };
    private ObjType thisObjType = ObjType.IMAGE;

    void Start() {
        //アタッチしてるオブジェクトを判別
        if (this.gameObject.GetComponent<Image>()) {
            thisObjType = ObjType.IMAGE;
            image = this.gameObject.GetComponent<Image>();
            gameObject.GetComponent<Image> ().color = new Color (1.0f, 1.0f, 1.0f, 0.0f);
		}else if(this.gameObject.GetComponent<Text>()){
			thisObjType = ObjType.TEXT;
			text = this.gameObject.GetComponent<Text>();
            gameObject.GetComponent<Text> ().color = new Color (1.0f, 1.0f, 1.0f, 0.0f);
		}
    }

    void Update () {

        //左クリックしたらコマンドが出てくる
        if(Input.GetMouseButtonDown(0)){

            if(this.gameObject.GetComponent<Image>()){
                image.color = new Color (1.0f, 1.0f, 1.0f, 0.5f);
            }else if(this.gameObject.GetComponent<Text>()){
                text.color = new Color (0.1f, 0.1f, 0.1f, 1.0f);
            }

        }

    }

}