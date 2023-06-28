using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anime : MonoBehaviour
{
    private Animator anim;// Animatorを使うための変数

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();// animにAnimatorの値を取得して代入
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))// もしWSADキーのいずれかが押されたら、

        {
            anim.SetBool("isRunning", true);// AnimatorのisRunningをtrueにする
        }

    }
}