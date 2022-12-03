using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_GameClear : MonoBehaviour
{
    public bool isGameClear;
    void Start()
    {
        isGameClear = false;
    }
    //ゴールにぶつかったらゴールシーンに移動する
    private void OnCollisionEnter(Collision collision)
    {
        // 当たった相手に"Hasrtu"タグが付いている場合
        //TimeCountのGameClear_Timeを実行するため、isGameClearをtrueにする
        if (collision.gameObject.tag == "Hasiru")
        {
            isGameClear = true;
        }
    }
}
