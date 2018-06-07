using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_con_2 : MonoBehaviour
{

    public float speed = 1.0f;

    private GameObject player;

    Vector3 m_offset = Vector3.up * 1.0f;

    private GameObject wall;

    Vector3 target = new Vector3(0, 0, 0.1f);

  

    // Use this for initialization
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        //wall = GameObject.FindGameObjectWithTag("DestroyWall");


        iTween.MoveTo(gameObject, iTween.Hash("position", player.transform.position + m_offset, "speed", speed, "easetype", "easeInOutQuad"));

    }


    //クリックしたオブジェクトを消す
    void OnMouseDown()
    {
        //GameObject.Find("EXT_UNT").GetComponent<EXT_Controller>().LookAt(transform.position);
        Destroy(this.gameObject,0.5f);
    }

    // Update is called once per frame
    void Update()
        {
        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime);


        /*
        Vector3 pos = transform.position;
        pos.z -= 10;
        transform.position = pos;
        */
        }


    /*
   {
   //ターゲットのほうに少しずつ向きを変える
   //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target)

   //ターゲットに向かって進む
   //transform.position = player.transform.position;

   //ターゲットの位置からyに+1.3の位置
   Vector3 pos = transform.position;
   pos.y = 1.3f;
   transform.position = pos;

   //ターゲットの位置からyに+1.3の位置に向かって進む
   //transform.position = GameObject.Find("Player").transform.position;
   //GameObject.Find("Player").transform.position = new Vector3(tmp.x, tmp.y + 1.3f, tmp.z);
   }
   */





}
