using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver_Drop : MonoBehaviour
{

    public AudioClip GameOverDropSE;//落ちるときの効果音
    AudioSource audioSource;
    public bool isGameOver;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        isGameOver = false;
    }
    //ゴールにぶつかったらゴールシーンに移動する
    private void OnCollisionEnter(Collision collision)
    {
        // 当たった相手に"Hasrtu"タグが付いている場合
        //TimeCountのGameOver_Timeを実行するため、isGameOverをtrueにする
        if (collision.gameObject.tag == "Hasiru")
        {
            audioSource.PlayOneShot(GameOverDropSE);//ゲームオーバー効果音
            isGameOver = true;
        }
    }
}
