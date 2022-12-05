using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Title_Scene : MonoBehaviour
{
    [SerializeField] Image StageSelectImage;
    [SerializeField] Button StageSelectButton;
    [SerializeField] Text StageSelectText;
    [SerializeField] Button FirstStageButton;
    [SerializeField] Image FirstStageImage;
    [SerializeField] Text FirstStageText;
    [SerializeField] Button ReturnButton;
    [SerializeField] Image ReturnImage;
    [SerializeField] Text ReturnText;
    //2022/12/5�ǉ��@�{�^�����L�[�I�������邽�߁A�ŏ��ɑI�������{�^������GameStart�Ƃ���FirstGameStartButton�ɓ����
    [SerializeField] Button FirstGameStartButton;
    public void OnStartButtonClicked()
    {//�����J�n�{�^���������ƍŏ�����n�߂�{�^���ƃX�e�[�W�I���{�^���A�߂�{�^�����\�������
        StageSelectImage.enabled = true;
        StageSelectButton.enabled = true;
        StageSelectText.enabled = true;
        FirstStageButton.enabled = true;
        FirstStageImage.enabled = true;
        FirstStageText.enabled = true;
        ReturnButton.enabled = true;
        ReturnImage.enabled = true;
        ReturnText.enabled = true;
        //2022/12/5�ǉ��@�{�^�����L�[�I�������邽�߁A�ŏ��ɑI�������{�^�����w������
        StageSelectButton.Select();
    }
    public void OnReturnButtonClicked()
    {//�߂�{�^���������ƍŏ�����n�߂�{�^���ƃX�e�[�W�I���{�^���A�߂�{�^������\���ɂ����
        StageSelectImage.enabled = false;
        StageSelectButton.enabled = false;
        StageSelectText.enabled = false;
        FirstStageButton.enabled = false;
        FirstStageImage.enabled = false;
        FirstStageText.enabled = false;
        ReturnButton.enabled = false;
        ReturnImage.enabled = false;
        ReturnText.enabled = false;
        FirstGameStartButton.Select();
    }


}
