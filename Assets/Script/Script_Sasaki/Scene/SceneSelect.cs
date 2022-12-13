using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneSelect : MonoBehaviour
{//�X�e�[�W�I����ʈړ��{�^��
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
        //�{�^�����L�[�I�������邽�߁A7���{�^����I������
        Stage0Button.Select();
        //�uSTAGE�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int StageReload = PlayerPrefs.GetInt("STAGE");
        //�����uSTAGE�v��0�Ȃ�Stage0�܂ł̃{�^����L��
        if (StageReload == 0)
        {
            Stage0Button.enabled = true;
            Stage0Button.image.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
        //�����uSTAGE�v��1�Ȃ�Stage1�܂ł̃{�^����L�� ����ȍ~�̃X�e�[�W�̃{�^���̐F���D�F
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
        //�����uSTAGE�v��2�Ȃ�Stage2_Takeda�܂ł̃{�^����L��
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
        //�����uSTAGE�v��3�Ȃ�Stage3_miura�܂ł̃{�^����L��
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
        //�����uSTAGE�v��4�Ȃ�Stage4_miura�܂ł̃{�^����L��
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

        //�����uSTAGE�v��5�Ȃ�Stage5_Takeda�܂ł̃{�^����L��
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
        //�����uSTAGE�v��6�Ȃ�Stage6_Takeda�܂ł̃{�^����L��
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

    public void OnStageSelect03ButtonClicked()
    {//Stage2_takeda�ړ��{�^��
        SceneManager.LoadScene("Stage3_miura");
    }
    public void OnStageSelect04ButtonClicked()
    {//Stage2_takeda�ړ��{�^��
        SceneManager.LoadScene("Stage4_miura");
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
