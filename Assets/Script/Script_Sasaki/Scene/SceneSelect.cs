using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSelect : MonoBehaviour
{//ステージ選択画面移動ボタン
    public void OnStageSelectButtonClicked()
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void OnStageSelect00ButtonClicked()
    {//Stage0移動ボタン
        SceneManager.LoadScene("Stage0");
    }

    public void OnStageSelect01ButtonClicked()
    {//Stage1移動ボタン
        SceneManager.LoadScene("Stage1");
    }

    public void OnStageSelect02ButtonClicked()
    {//Stage2_takeda移動ボタン
        SceneManager.LoadScene("Stage2_takeda");
    }

    public void OnStageSelect05ButtonClicked()
    {//Stage5_takeda移動ボタン
        SceneManager.LoadScene("Stage5_takeda");
    }

    public void OnStageSelect06ButtonClicked()
    {//Stage6_takeda移動ボタン
        SceneManager.LoadScene("Stage6_takeda");
    }
}
