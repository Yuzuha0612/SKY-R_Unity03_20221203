using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameClear_Score : MonoBehaviour
{//ClearStarImageに星の画像
    [SerializeField] Image ClearStarImage1;
    [SerializeField] Image ClearStarImage2;
    [SerializeField] Image ClearStarImage3;
    //NextStage○○に次のステージ移行ボタン
    [SerializeField] Image NextStageImage;
    [SerializeField] Button NextStageButton;
    [SerializeField] Text NextStageText;
    public Text TimeLeftLabel;
    //2022年12月11日最終ステージだけキー操作を行うための透明ボタン
    [SerializeField] Button FirstSelectButton;
    void Start()
    {
        NextStageImage.enabled = true;
        NextStageButton.enabled = true;
        NextStageText.enabled = true;
    }

    void Update()
    {
        //「TIMEFLOAT」というキーで保存されているFloat値を読み込み
        float TimeLeftFloat = PlayerPrefs.GetFloat("TIMEFLOAT");
        //残り時間を表示させる
        TimeLeftLabel.text = TimeLeftFloat.ToString("0.00") + "秒!"; //fixapdate
        //残り時間に応じて星の数を変更させる
        //TimeCountの呼び出し
        //「TIME」というキーで保存されているInt値を読み込み
        int TimeLeft = PlayerPrefs.GetInt("TIME");
        if (TimeLeft < 3 )
        {//「TIME」が3秒以下の時は星を一つ表示させる
            ClearStarImage1.enabled = true;
        } else if (TimeLeft > 7)
        {//「TIME」が7秒以上の時は星を三つ表示させる
            ClearStarImage1.enabled = true;
            ClearStarImage2.enabled = true;
            ClearStarImage3.enabled = true;
        }  else
        {//「TIME」が3秒以上7秒未満の時は星を二つ表示させる
            ClearStarImage1.enabled = true;
            ClearStarImage2.enabled = true;
        }
        //「STAGE」というキーで保存されているInt値を読み込み
        int NextStage = PlayerPrefs.GetInt("STAGE");
        //NextStageに1を足す
        NextStage++;
        //最後のステージの場合
        //2022年12月11日もし「STAGE」が7ならボタンを非表示にさせ、透明ボタンを有効にする
        if (NextStage == 7)
        {
            NextStageImage.enabled = false;
            NextStageButton.enabled = false;
            NextStageText.enabled = false;
            FirstSelectButton.enabled = true;
        }
    }
    public void OnReturnTitleClearButtonClicked()
    {//タイトルに戻る
        SceneManager.LoadScene("Title");
    }
    public void OnNextStageButtonClicked()
    {
        //「STAGE」というキーで保存されているInt値を読み込み
        int NextStage= PlayerPrefs.GetInt("STAGE");
        //NextStageに1を足す
        NextStage++;
        //クリアした次のステージを表示させる
        //もし「STAGE」が1ならStage1に移動する
        if (NextStage == 1)
        {
            SceneManager.LoadScene("Stage1");
        }
        //もし「STAGE」が2ならStage2_Takedaに移動する
        if (NextStage == 2)
        {
            SceneManager.LoadScene("Stage2_takeda");
        }
        //もし「STAGE」が3ならStage3_miuraに移動する
        if (NextStage == 3)
        {
            SceneManager.LoadScene("Stage3_miura");
        }
        //もし「STAGE」が4ならStage4_miuraに移動する
        if (NextStage == 4)
        {
            SceneManager.LoadScene("Stage4_miura");
        }

        //もし「STAGE」が5ならStage5_Takedaに移動する
        if (NextStage == 5)
        {
            SceneManager.LoadScene("Stage5_takeda");
        }
        //もし「STAGE」が6ならStage6_Takedaに移動する
        if (NextStage == 6)
        {
            SceneManager.LoadScene("Stage6_takeda");
        }
       

    }
}
