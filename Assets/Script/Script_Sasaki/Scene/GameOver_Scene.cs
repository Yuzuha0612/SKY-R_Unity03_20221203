using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver_Scene : MonoBehaviour
{
    public void OnTitleReloadButtonClicked()
    {
        SceneManager.LoadScene("Title");
    }
    public void OnRetryButtonClicked()
    {
        //「STAGE」というキーで保存されているInt値を読み込み
        int StageReload = PlayerPrefs.GetInt("STAGE");
        //もし「STAGE」が0ならStage0に移動する
        if (StageReload == 0)
        {
            SceneManager.LoadScene("Stage0");
        }
        //もし「STAGE」が1ならStage1に移動する
        if (StageReload == 1)
        {
            SceneManager.LoadScene("Stage1");
        }
        //もし「STAGE」が2ならStage2_Takedaに移動する
        if (StageReload == 2)
        {
            SceneManager.LoadScene("Stage2_takeda");
        }
        //もし「STAGE」が3ならStage3_miuraに移動する
        if (StageReload == 3)
        {
            SceneManager.LoadScene("Stage3_miura");
        }
        //もし「STAGE」が4ならStage4_miuraに移動する
        if (StageReload == 4)
        {
            SceneManager.LoadScene("Stage4_miura");
        }
      
        //もし「STAGE」が5ならStage5_Takedaに移動する
        if (StageReload == 5)
        {
            SceneManager.LoadScene("Stage5_takeda");
        }
        //もし「STAGE」が6ならStage6_Takedaに移動する
        if (StageReload == 6)
        {
            SceneManager.LoadScene("Stage6_takeda");
        }

    }
}
