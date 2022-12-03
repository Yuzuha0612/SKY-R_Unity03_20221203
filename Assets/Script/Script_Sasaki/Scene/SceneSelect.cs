using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSelect : MonoBehaviour
{//�X�e�[�W�I����ʈړ��{�^��
    public void OnStageSelectButtonClicked()
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void OnStageSelect00ButtonClicked()
    {//Stage0�ړ��{�^��
        SceneManager.LoadScene("Stage0");
    }

    public void OnStageSelect01ButtonClicked()
    {//Stage1�ړ��{�^��
        SceneManager.LoadScene("Stage1");
    }

    public void OnStageSelect02ButtonClicked()
    {//Stage2_takeda�ړ��{�^��
        SceneManager.LoadScene("Stage2_takeda");
    }

    public void OnStageSelect05ButtonClicked()
    {//Stage5_takeda�ړ��{�^��
        SceneManager.LoadScene("Stage5_takeda");
    }

    public void OnStageSelect06ButtonClicked()
    {//Stage6_takeda�ړ��{�^��
        SceneManager.LoadScene("Stage6_takeda");
    }
}
