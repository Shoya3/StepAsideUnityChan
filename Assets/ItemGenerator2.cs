using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator2 : MonoBehaviour {
    //carPrefabを入れる
    public GameObject carPrefab;
    //coinPrefabを入れる
    public GameObject coinPrefab;
    //conePrefabを入れる
    public GameObject conePrefab;
    //スタート地点
    private int startPos = -160;
    //ゴール地点
    private int goalPos = 120;
    //アイテムを出すx方向の範囲
    private float posRange = 3.4f;
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //Unityちゃんの位置情報
    private float unitychanPosZ;
    //アイテムを生成させるz座標
    private float itemPos=-120;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        unitychan = GameObject.Find("unitychan");
        unitychanPosZ = unitychan.transform.position.z;
        //unityちゃんがz座標-210まで来たらアイテム生成開始
        if (startPos - 50 < unitychanPosZ)
        {
            if(itemPos-50<unitychanPosZ && itemPos <= goalPos)
            {
                //どのアイテムを出すのかランダムに設定
                int num = Random.Range(1, 11);

                if (num <= 2)
                {
                    //コーンをx軸方向に一直線に生成
                    for (float j = -1; j <= 1; j += 0.4f)
                    {
                        GameObject cone = Instantiate(conePrefab) as GameObject;
                        cone.transform.position = new Vector3(4 * j, cone.transform.position.y, itemPos);
                        //生成した時間を表示
                        Debug.Log("コーン生成"+Time.time);
                    }
                }
                else
                {
                    //レーンごとにアイテムを生成
                    for (int j = -1; j <= 1; j++)
                    {
                        //アイテムの種類を決める
                        int item = Random.Range(1, 11);
                        //アイテムを置くZ座標のオフセットをランダムに設定
                        int offsetZ = Random.Range(-5, 6);
                        //60%コイン配置：30%車配置:10%何もなし
                        if (1 <= item && item <= 6)
                        {
                            //コインを生成
                            GameObject coin = Instantiate(coinPrefab) as GameObject;
                            coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, itemPos + offsetZ);
                            //生成した時間を表示
                            Debug.Log("コイン生成"+Time.time);

                        }
                        else if (7 <= item && item <= 9)
                        {
                            //車を生成
                            GameObject car = Instantiate(carPrefab) as GameObject;
                            car.transform.position = new Vector3(posRange * j, car.transform.position.y, itemPos + offsetZ);
                            //生成した時間を表示
                            Debug.Log("車生成"+Time.time);
                        }
                    }
                }

                itemPos += 15;
            }
        }
	}
}
