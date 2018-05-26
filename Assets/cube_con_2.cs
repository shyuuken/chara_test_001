using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_con_2 : MonoBehaviour
{

    // Use this for initialization
    void Start() { }

    //クリックしたオブジェクトを消す
    void OnMouseDown()
    {
        Destroy(this.gameObject,0.5f);
    }


    // Update is called once per frame
    void Update()
    {
        //マウスがクリックされた場合
        if (Input.GetMouseButtonDown(0))
        {

            //メインカメラ上で　カーソルのあった場所にRayを飛ばす
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                //Rayが当たるオブジェクトがあった場合はそのオブジェクト名をログに表示
                Debug.Log(hit.collider.gameObject.name);
            }
        }
    }
}
