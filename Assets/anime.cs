using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anime : MonoBehaviour
{
    private Animator anim; // Animatorを使うための変数
    private float originalX; // 初期のx座標を保存するための変数
    private float distance = 5.0f; // 左右する距離
    private float speed = 2.0f; // 左右するスピード

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); // animにAnimatorの値を取得して代入
        anim.SetBool("isWalking", true); // AnimatorのisWalkingをtrueにする
        originalX = transform.position.x; // originalXに現在のx座標を保存
        transform.Rotate(0, 90, 0);
    }

    // Update is called once per frame
    void Update()
    {   
        transform.position += transform.forward * 0.04f; // 前方に進む

        // 現在のx座標がoriginalXからdistance分以上離れた場合、または0以下の場合に90度回転
        if (transform.position.x <= 0 || transform.position.x >= originalX + distance)
        {
            // 90度回転させる
            transform.Rotate(0, 180, 0);

            // 新しいx座標をoriginalXとして保存
            originalX = transform.position.x;
        }
    }
}
