using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame_Button : MonoBehaviour
{
    //�w�i
    [SerializeField] Image EndGameWarningImage;
    //�������{�^��
    [SerializeField] Button EndGameWarningCloseButton;
    [SerializeField] Image EndGameWarningCloseImage;
    [SerializeField] Text EndGameWarningCloseText;
    //�Q�[���I�����܂����e�L�X�g
    [SerializeField] Text EndGameWarningText;
    //�͂��{�^��
    [SerializeField] Button EndGameButton;
    [SerializeField] Image EndGameImage;
    [SerializeField] Text EndGameText;
    public void OnEndGameFirstButtonClicked()
    {//�ŏ��ɃQ�[���I���{�^���������ƃQ�[���I���x����ʂ��\�������
        EndGameWarningImage.enabled = true;
        EndGameWarningText.enabled = true;
        EndGameWarningCloseButton.enabled = true;
        EndGameWarningCloseImage.enabled = true;
        EndGameWarningCloseText.enabled = true;
        EndGameButton.enabled = true;
        EndGameImage.enabled = true;
        EndGameText.enabled = true;
    }

    public void OnEndGameSecondButtonOffClicked()
    {//�͂��������ƃQ�[�����I������
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
#else
    Application.Quit();//�Q�[���v���C�I��
#endif
    }
    public void OnEndGameWarningButtonOffClicked()
    {//�������������ƃX�e�[�W�I����ʂɖ߂�
        EndGameWarningImage.enabled = false;
        EndGameWarningText.enabled = false;
        EndGameWarningCloseButton.enabled = false;
        EndGameWarningCloseImage.enabled = false;
        EndGameWarningCloseText.enabled = false;
        EndGameButton.enabled = false;
        EndGameImage.enabled = false;
        EndGameText.enabled = false;
    }
}
