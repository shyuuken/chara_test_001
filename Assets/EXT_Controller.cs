using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXT_Controller : MonoBehaviour {
    bool isAttack;
	// Use this for initialization
	void Start () {
		
	}
	
    public void FinishAttack()
    {
        isAttack = false;
    }


	// Update is called once per frame
	void Update () {
        //  マウスがクリックされた場合
        if (Input.GetMouseButtonDown(0))
        {
            if(!isAttack)
            {
                isAttack = true;
                //Animatorコンポーネントを取得し、"atk_001_Trigger"をtrueにする
                GetComponent<Animator>().SetTrigger("atk_001_Trigger");
            }
            
        }



    }
}
