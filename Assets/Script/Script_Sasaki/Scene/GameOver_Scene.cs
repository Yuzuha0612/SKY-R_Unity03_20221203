using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver_Scene : MonoBehaviour
{
    public void OnTitleReloadButtonClicked()
    {
        //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
        FadeManager.Instance.LoadScene("Title", 0.5f);
    }
    public void OnRetryButtonClicked()
    {
        //「STAGE」というキーで保存されているInt値を読み込み
        int StageReload = PlayerPrefs.GetInt("STAGE");
        //もし「STAGE」が0ならStage0に移動する
        if (StageReload == 0)
        {
            //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
            FadeManager.Instance.LoadScene("Stage0", 0.5f);
        }
        //もし「STAGE」が1ならStage1に移動する
        if (StageReload == 1)
        {
            //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
            FadeManager.Instance.LoadScene("Stage1", 0.5f);
        }
        //もし「STAGE」が2ならStage2_Takedaに移動する
        if (StageReload == 2)
        {
            //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
            FadeManager.Instance.LoadScene("Stage2_takeda", 0.5f);
        }
        //もし「STAGE」が3ならStage3_miuraに移動する
        if (StageReload == 3)
        { //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
            FadeManager.Instance.LoadScene("Stage3_miura", 0.5f);
        }
        //もし「STAGE」が4ならStage4_miuraに移動する
        if (StageReload == 4)
        { //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
            FadeManager.Instance.LoadScene("Stage4_miura", 0.5f);
        }
      
        //もし「STAGE」が5ならStage5_Takedaに移動する
        if (StageReload == 5)
        {
            //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
            FadeManager.Instance.LoadScene("Stage5_takeda", 0.5f);
        }
        //もし「STAGE」が6ならStage6_Takedaに移動する
        if (StageReload == 6)
        {
            //2022/12/19　シーン切り替え時にフェードインフェードアウトの演出を追加
            FadeManager.Instance.LoadScene("Stage6_takeda", 0.5f);
        }

    }
}
