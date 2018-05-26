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
            var animator = GetComponent<Animator>();
            if(!animator.GetCurrentAnimatorStateInfo(0).IsName("atk_001")
                && !animator.IsInTransition(0)
            )
            {
                animator.SetTrigger("atk_001_Trigger");
            }
            
        }



    }
}
