using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_con_2 : MonoBehaviour
{

    public float speed = 1.0f;

    private GameObject player;

    // Use this for initialization
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    //クリックしたオブジェクトを消す
    void OnMouseDown()
    {
        GameObject.Find("EXT_UNT").GetComponent<EXT_Controller>().LookAt(transform.position);
        Destroy(this.gameObject,0.5f);
    }


    // Update is called once per frame
    void Update()
    {

        
    }
}
