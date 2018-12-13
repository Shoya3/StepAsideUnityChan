using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDelete : MonoBehaviour
{
    //unitychanのオブジェクトを格納
    private GameObject unitychan;
    //unitychanのz座標情報
    private float unitychanPos;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.unitychan = GameObject.Find("unitychan");
        unitychanPos = unitychan.transform.position.z;

        if (this.transform.position.z < unitychanPos - 2.0f)
        {
            Destroy(this.gameObject);
            Debug.Log("コイン消去");
        }
    }
}
