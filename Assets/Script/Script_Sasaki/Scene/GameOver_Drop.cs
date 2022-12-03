using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver_Drop : MonoBehaviour
{
    public bool isGameOver;
    void Start()
    {
        isGameOver = false;
    }
    //ゴールにぶつかったらゴールシーンに移動する
    private void OnCollisionEnter(Collision collision)
    {
        // 当たった相手に"Hasrtu"タグが付いている場合
        //TimeCountのGameOver_Timeを実行するため、isGameOverをtrueにする
        if (collision.gameObject.tag == "Hasiru")
        {
            isGameOver = true;
        }
    }
}
