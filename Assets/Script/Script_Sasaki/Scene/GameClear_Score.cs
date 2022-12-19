using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameClear_Score : MonoBehaviour
{//ClearStarImage�ɐ��̉摜
    [SerializeField] Image ClearStarImage1;
    [SerializeField] Image ClearStarImage2;
    [SerializeField] Image ClearStarImage3;
    //NextStage�����Ɏ��̃X�e�[�W�ڍs�{�^��
    [SerializeField] Image NextStageImage;
    [SerializeField] Button NextStageButton;
    [SerializeField] Text NextStageText;
    public Text TimeLeftLabel;
    //2022�N12��11���ŏI�X�e�[�W�����L�[������s�����߂̓����{�^��
    [SerializeField] Button FirstSelectButton;
    void Start()
    {
        NextStageImage.enabled = true;
        NextStageButton.enabled = true;
        NextStageText.enabled = true;
    }

    void Update()
    {
        //�uTIMEFLOAT�v�Ƃ����L�[�ŕۑ�����Ă���Float�l��ǂݍ���
        float TimeLeftFloat = PlayerPrefs.GetFloat("TIMEFLOAT");
        //�c�莞�Ԃ�\��������
        TimeLeftLabel.text = TimeLeftFloat.ToString("0.00") + "�b!"; //fixapdate
        //�c�莞�Ԃɉ����Đ��̐���ύX������
        //TimeCount�̌Ăяo��
        //�uTIME�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int TimeLeft = PlayerPrefs.GetInt("TIME");
        if (TimeLeft < 3 )
        {//�uTIME�v��3�b�ȉ��̎��͐�����\��������
            ClearStarImage1.enabled = true;
        } else if (TimeLeft > 7)
        {//�uTIME�v��7�b�ȏ�̎��͐����O�\��������
            ClearStarImage1.enabled = true;
            ClearStarImage2.enabled = true;
            ClearStarImage3.enabled = true;
        }  else
        {//�uTIME�v��3�b�ȏ�7�b�����̎��͐����\��������
            ClearStarImage1.enabled = true;
            ClearStarImage2.enabled = true;
        }
        //�uSTAGE�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int NextStage = PlayerPrefs.GetInt("STAGE");
        //NextStage��1�𑫂�
        NextStage++;
        //�Ō�̃X�e�[�W�̏ꍇ
        //2022�N12��11�������uSTAGE�v��7�Ȃ�{�^�����\���ɂ����A�����{�^����L���ɂ���
        if (NextStage == 7)
        {
            NextStageImage.enabled = false;
            NextStageButton.enabled = false;
            NextStageText.enabled = false;
            FirstSelectButton.enabled = true;
        }
    }
    public void OnReturnTitleClearButtonClicked()
    {
        //2022/12/19�@�V�[���؂�ւ����Ƀt�F�[�h�C���t�F�[�h�A�E�g�̉��o��ǉ�
        FadeManager.Instance.LoadScene("Title", 0.5f);
    }
    public void OnNextStageButtonClicked()
    {
        //�uSTAGE�v�Ƃ����L�[�ŕۑ�����Ă���Int�l��ǂݍ���
        int NextStage= PlayerPrefs.GetInt("STAGE");
        //NextStage��1�𑫂�
        NextStage++;
        //�N���A�������̃X�e�[�W��\��������
        //�����uSTAGE�v��1�Ȃ�Stage1�Ɉړ�����
        if (NextStage == 1)
        {
            //2022/12/19�@�V�[���؂�ւ����Ƀt�F�[�h�C���t�F�[�h�A�E�g�̉��o��ǉ�
            FadeManager.Instance.LoadScene("Stage1", 0.5f);
        }
        //�����uSTAGE�v��2�Ȃ�Stage2_Takeda�Ɉړ�����
        if (NextStage == 2)
        {//2022/12/19�@�V�[���؂�ւ����Ƀt�F�[�h�C���t�F�[�h�A�E�g�̉��o��ǉ�
            FadeManager.Instance.LoadScene("Stage2_takeda", 0.5f);
        }
        //�����uSTAGE�v��3�Ȃ�Stage3_miura�Ɉړ�����
        if (NextStage == 3)
        {
            //2022/12/19�@�V�[���؂�ւ����Ƀt�F�[�h�C���t�F�[�h�A�E�g�̉��o��ǉ�
            FadeManager.Instance.LoadScene("Stage3_miura", 0.5f);
        }
        //�����uSTAGE�v��4�Ȃ�Stage4_miura�Ɉړ�����
        if (NextStage == 4)
        {
            //2022/12/19�@�V�[���؂�ւ����Ƀt�F�[�h�C���t�F�[�h�A�E�g�̉��o��ǉ�
            FadeManager.Instance.LoadScene("Stage4_miura", 0.5f);
        }

        //�����uSTAGE�v��5�Ȃ�Stage5_Takeda�Ɉړ�����
        if (NextStage == 5)
        {
            //2022/12/19�@�V�[���؂�ւ����Ƀt�F�[�h�C���t�F�[�h�A�E�g�̉��o��ǉ�
            FadeManager.Instance.LoadScene("Stage5_takeda", 0.5f);
        }
        //�����uSTAGE�v��6�Ȃ�Stage6_Takeda�Ɉړ�����
        if (NextStage == 6)
        {
            //2022/12/19�@�V�[���؂�ւ����Ƀt�F�[�h�C���t�F�[�h�A�E�g�̉��o��ǉ�
            FadeManager.Instance.LoadScene("Stage6_takeda", 0.5f);
        }
       

    }
}
