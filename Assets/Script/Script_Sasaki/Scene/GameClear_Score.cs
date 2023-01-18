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
    [SerializeField] Button TitleReloadButton;
    public Text TimeLeftLabel;
    //2022年12月11日最終ステージだけキー操作を行うための透明ボタン
    [SerializeField] Button FirstSelectButton;
    [SerializeField] Text StageClearText;
    void Start()
    {
        NextStageImage.enabled = true;
        NextStageButton.enabled = true;
        NextStageText.enabled = true;
        //「STAGE」というキーで保存されているInt値を読み込み
        int ClearStage = PlayerPrefs.GetInt("STAGECLASS");
        StageClearText.text = ClearStage + "級合格！" ;
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
        //2023/1/7もし「STAGE」が9ならボタンを非表示にさせ、透明ボタンを有効にする
        if (NextStage == 9)
        {
            NextStageImage.enabled = false;
            NextStageButton.enabled = false;
            NextStageText.enabled = false;
            FirstSelectButton.enabled = true;
            TitleReloadButton.Select();//2023/1/11追加　タイトルボタン選択
        }
        if (Input.GetMouseButtonDown(0))
        {
            TitleReloadButton.Select();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void OnReturnTitleClearButtonClicked()
    {
        //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
        FadeManager.Instance.LoadScene("Title", 0.5f);
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
            //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
            FadeManager.Instance.LoadScene("Stage1", 0.5f);
        }
        //もし「STAGE」が2ならStage2_Takedaに移動する
        if (NextStage == 2)
        {//2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
            FadeManager.Instance.LoadScene("Stage2_takeda", 0.5f);
        }
        //もし「STAGE」が3ならStageEle_miuraに移動する
        if (NextStage == 3)
        {
            FadeManager.Instance.LoadScene("StageEle_miura", 0.5f);
        }
        //もし「STAGE」が4ならStage3_miuraに移動する
        if (NextStage == 4)
        {
            //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
            FadeManager.Instance.LoadScene("Stage3_miura", 0.5f);
        }
        //もし「STAGE」が5ならStageSabo_miuraに移動する
        if (NextStage == 5)
        {
            //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
            FadeManager.Instance.LoadScene("StageSabo_miura", 0.5f);
        }
        //もし「STAGE」が6ならStage4_miuraに移動する
        if (NextStage == 6)
        {
            //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
            FadeManager.Instance.LoadScene("Stage4_miura", 0.5f);
        }

        //もし「STAGE」が7ならStage5_Takedaに移動する
        if (NextStage == 7)
        {
            //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
            FadeManager.Instance.LoadScene("Stage5_takeda", 0.5f);
        }
        //もし「STAGE」が8ならStage6_Takedaに移動する
        if (NextStage == 8)
        {
            //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
            FadeManager.Instance.LoadScene("Stage6_takeda", 0.5f);
        }
       

    }
}
