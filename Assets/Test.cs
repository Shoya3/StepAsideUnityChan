using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    //アニメーションするためのコンポーネントを入れる
    private Animator myAnimator;

    // Use this for initialization
    void Start()
    {
        //Animatorコンポーネントを取得
        this.myAnimator = GetComponent<Animator>();

        //走るモーションを開始
        this.myAnimator.SetFloat("Speed", 1);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
