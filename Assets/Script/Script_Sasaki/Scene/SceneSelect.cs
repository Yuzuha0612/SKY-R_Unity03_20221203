using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneSelect : MonoBehaviour
{//ステージ選択画面移動ボタン
    [SerializeField] Button Stage0Button;
    [SerializeField] Button Stage1Button;
    [SerializeField] Button Stage2Button;
    [SerializeField] Image Stage2Image;
    [SerializeField] Button Stage3Button;
    [SerializeField] Image Stage3Image;
    [SerializeField] Button Stage4Button;
    [SerializeField] Image Stage4Image;
    [SerializeField] Button Stage5Button;
    [SerializeField] Image Stage5Image;
    [SerializeField] Button Stage6Button;
    [SerializeField] Image Stage6Image;
    void Start()
    {
        //ボタンをキー選択させるため、7級ボタンを選択する
        Stage0Button.Select();
        //「STAGE」というキーで保存されているInt値を読み込み
        int StageReload = PlayerPrefs.GetInt("STAGE");
        //もし「STAGE」が0ならStage0までのボタンを有効
        if (StageReload == 0)
        {
            Stage0Button.enabled = true;
            Stage0Button.image.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
        //もし「STAGE」が1ならStage1までのボタンを有効 それ以降のステージのボタンの色を灰色
        if (StageReload == 1)
        {
            Stage0Button.enabled = true;
            Stage1Button.enabled = true;
            Stage2Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage3Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage4Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage5Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage6Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
        }
        //もし「STAGE」が2ならStage2_Takedaまでのボタンを有効
        if (StageReload == 2)
        {
            Stage0Button.enabled = true;
            Stage1Button.enabled = true;
            Stage2Button.enabled = true;
            Stage3Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage4Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage5Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage6Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
        }
        //もし「STAGE」が3ならStage3_miuraまでのボタンを有効
        if (StageReload == 3)
        {
            Stage0Button.enabled = true;
            Stage1Button.enabled = true;
            Stage2Button.enabled = true;
            Stage3Button.enabled = true;
            Stage4Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage5Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage6Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
        }
        //もし「STAGE」が4ならStage4_miuraまでのボタンを有効
        if (StageReload == 4)
        {
            Stage0Button.enabled = true;
            Stage1Button.enabled = true;
            Stage2Button.enabled = true;
            Stage3Button.enabled = true;
            Stage4Button.enabled = true;
            Stage5Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
            Stage6Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
        }

        //もし「STAGE」が5ならStage5_Takedaまでのボタンを有効
        if (StageReload == 5)
        {
            Stage0Button.enabled = true;
            Stage1Button.enabled = true;
            Stage2Button.enabled = true;
            Stage3Button.enabled = true;
            Stage4Button.enabled = true;
            Stage5Button.enabled = true;
            Stage6Image.color = new Color(0.7f, 0.7f, 0.7f, 1.0f);
        }
        //もし「STAGE」が6ならStage6_Takedaまでのボタンを有効
        if (StageReload == 6)
        {
            Stage0Button.enabled = true;
            Stage1Button.enabled = true;
            Stage2Button.enabled = true;
            Stage3Button.enabled = true;
            Stage4Button.enabled = true;
            Stage5Button.enabled = true;
            Stage6Button.enabled = true;
        }
    }
   
   
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

    public void OnStageSelect03ButtonClicked()
    {//Stage2_takeda移動ボタン
        SceneManager.LoadScene("Stage3_miura");
    }
    public void OnStageSelect04ButtonClicked()
    {//Stage2_takeda移動ボタン
        SceneManager.LoadScene("Stage4_miura");
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
