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
        //�uSTAGE�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int StageReload = PlayerPrefs.GetInt("STAGE");
        //�����uSTAGE�v��0�Ȃ�Stage0�Ɉړ�����
        if (StageReload == 0)
        {
            SceneManager.LoadScene("Stage0");
        }
        //�����uSTAGE�v��1�Ȃ�Stage1�Ɉړ�����
        if (StageReload == 1)
        {
            SceneManager.LoadScene("Stage1");
        }
        //�����uSTAGE�v��2�Ȃ�Stage2_Takeda�Ɉړ�����
        if (StageReload == 2)
        {
            SceneManager.LoadScene("Stage2_takeda");
        }
        //�����uSTAGE�v��3�Ȃ�Stage3_miura�Ɉړ�����
        if (StageReload == 3)
        {
            SceneManager.LoadScene("Stage3_miura");
        }
        //�����uSTAGE�v��4�Ȃ�Stage4_miura�Ɉړ�����
        if (StageReload == 4)
        {
            SceneManager.LoadScene("Stage4_miura");
        }
      
        //�����uSTAGE�v��5�Ȃ�Stage5_Takeda�Ɉړ�����
        if (StageReload == 5)
        {
            SceneManager.LoadScene("Stage5_takeda");
        }
        //�����uSTAGE�v��6�Ȃ�Stage6_Takeda�Ɉړ�����
        if (StageReload == 6)
        {
            SceneManager.LoadScene("Stage6_takeda");
        }

    }
}
