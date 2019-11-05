using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Exphoge : MonoBehaviour
{

    Slider hpSlider;
	public GameObject level_object = null; // Textオブジェクト

	Text levelnum_text;

	int level = 1;

    // Use this for initialization
    void Start()
    {
        hpSlider = GetComponent<Slider>();

        float maxHp = 200f;
        float nowHp = 0f;

        //スライダーの最大値の設定
        hpSlider.maxValue = maxHp;

        //スライダーの現在値の設定
        hpSlider.value = nowHp;

		// オブジェクトからTextコンポーネントを取得
    	levelnum_text = level_object.GetComponent<Text> ();

    }

    // Update is called once per frame
    void Update()
    {
		
		//クリックしたときにhpを10減らす。
		if(Input.GetMouseButton(0))
		{
			hpSlider.value += 1f;

			if(hpSlider.value == 200f)
			{
				
				level += 1;
				hpSlider.value = 0f;

			}
		}
		Debug.Log(hpSlider.value + " , " + level);

        // テキストの表示を入れ替える
        levelnum_text.text = "" + level;
    }
}