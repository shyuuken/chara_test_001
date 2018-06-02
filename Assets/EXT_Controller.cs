using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXT_Controller : MonoBehaviour
{
    //検知用レイ
    private RaycastHit hit;

    //攻撃用エフェクト
    public GameObject beam_prehub;


    bool isAttack;

    
    
    // Use this for initialization
    void Start()
    {

    }

    public void FinishAttack()
    {
        isAttack = false;
    }

    public void LookAt(Vector3 position)
    {
        transform.LookAt(position);
    }

    // Update is called once per frame
    void Update()
    {
        

        //  マウスがクリックされた場合
        if (Input.GetMouseButtonDown(0))
        {
            //攻撃用のアニメーション"atk_001"を再生
            var animator = GetComponent<Animator>();
            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("atk_001")
                && !animator.IsInTransition(0))
            {
                beam_prehub.GetComponent<ParticleSystem>().Play();
                animator.SetTrigger("atk_001_Trigger");
            }

            /*
            // 攻撃エフェクトをインスタンス化
            var obj = Instantiate(beam_prehub, transform.position + transform.forward, Quaternion.identity) as GameObject;
            */


            //メインカメラ上で　カーソルのあった場所にRayを飛ばす
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                //Rayが当たった場所をログに表示
                Debug.Log(hit.collider.gameObject.name);

                //var look = Quaternion.LookRotation(hit.point);

            }

            //Rayのヒットした場所を向く

            /*var newRotation = Quaternion.LookRotation(hit.point - transform.position).eulerAngles;
            newRotation.x = 0;
            newRotation.z = 0;
            transform.rotation = Quaternion.Euler(newRotation);
            */

        }

    }

}

