using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.PostProcessing;

public class Timecounte : MonoBehaviour
{
    //timeCount �������ԁ@�X�N���v�g��MainCamera�ɓ���Ă܂�
    public Text timeLabel;
    public float timeCount;
    //2022/11/27�ǉ��@���݂̃X�e�[�W�ԍ�
    public int StageNumber;
    //2022/11/23�ǉ� �Q�[���J�n����
    bool isStart = false;
    public int TimeCountint;
    [SerializeField] Text StartClickEnter;
    public GameObject GoalObject;
    public GameObject GameOverArea;
    //public GameObject Sabodon;
    //2022�N12��9���ǉ��@���Ԓ�~�G�t�F�N�g���擾���邽�߁AMainCamera��TimeStopPostProcessLayer�ɓ����
    public PostProcessLayer TimeStopPostProcessLayer;
    void Start()
    {
        timeCount = 10;
        timeLabel.text = "TIME:" + timeCount; //fixapdate
        GoalObject = GameObject.FindGameObjectWithTag("Goal");
        GameOverArea = GameObject.FindGameObjectWithTag("GameOverArea");
        //Sabodon = GameObject.FindGameObjectWithTag("TogeToge");
        //2022�N12��9���ǉ��@���Ԓ�~�G�t�F�N�g���I�t�ɂ���
        TimeStopPostProcessLayer.enabled = false;
    }

    void Update()
    {

        //2022/11/23�ǉ� �Q�[���J�n����
        //2022/11/23�ǉ� �Q�[���J�n���� �S�ẴL�[�Ή�
        if (isStart == false && Input.anyKey)
        {
            isStart = true;
            StartClickEnter.enabled = false;
        }
        if (isStart == true)
        {
            //���E�L�[�̂ǂ��炩�������ꂽ�Ƃ����Ԃ������̂��~�߂邻��ȊO��TimedeltaTime�Ŏ��Ԍo�� && Sabodon.GetComponent<Sabodon>().isTogeDamege
            if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)) &&(Sabodon. instance.isTogeDamege))
            {
                timeLabel.text = "TIME:" + timeCount.ToString("0.00");
                //2022�N12��9���ǉ��@���Ԓ�~�G�t�F�N�g���I���ɂ���
                TimeStopPostProcessLayer.enabled = true;
            }
            else
            {
                timeCount -= Time.deltaTime;
                timeLabel.text = "TIME:" + timeCount.ToString("0.00");
                //2022�N12��9���ǉ��@���Ԓ�~�G�t�F�N�g���I�t�ɂ���
                TimeStopPostProcessLayer.enabled = false;
            }
            //2022�N12��9���ǉ��@�L�[����������y�i���e�B�Ƃ���0.1�b���炷
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                timeLabel.text = "TIME:" + timeCount.ToString("0.00");
                timeCount -= 0.1f;
            }
        }
        if (timeCount < 4)
        {//2022/12/11�ǉ��@�c��4�b�ɂȂ����琧�����Ԃ�ԐF�ɂ���
         //4�b�ȉ��ɂȂ�����
         //�ԐF�ɂ���
            timeLabel.color = new Color(1.0f, 0.0f ,0.0f ,1.0f);
        }
        if (timeCount < 0)
        {//2022/11/27�ǉ��@�Q�[���I�[�o�[���猻�݂̃X�e�[�W�ɖ߂��Ă���
            //0�b�ȉ��ɂȂ�����
            //�uSTAGE�v�Ƃ����L�[�ŁAInt�l�́uStageNumber�v��ۑ�
            PlayerPrefs.SetInt("STAGE", StageNumber);
            PlayerPrefs.Save();
            //�Q�[���I�[�o�[��ʂɈړ�
            //2022/12/19�@�V�[���؂�ւ����Ƀt�F�[�h�C���t�F�[�h�A�E�g�̉��o��ǉ�
            FadeManager.Instance.LoadScene("GameOver", 0.3f);
        }

        if (GoalObject.GetComponent<Goal_GameClear>().isGameClear)
        {
            GameClear_Time();
        }
        if (GameOverArea.GetComponent<GameOver_Drop>().isGameOver)
        {
            GameOver_Drop();
        }
    }

    private void GameClear_Time()
    {
        //2022/11/27�ǉ��@timeCount�̏����_�ȉ���؂�̂āAint�^�ɕϊ�
        TimeCountint = (int)timeCount;
        //�Q�[���N���A��ʈړ��ƃN���A�^�C���ۑ�
        //0�b�ȉ��ɂȂ�����
        //�uSTAGE�v�Ƃ����L�[�ŁAInt�l�́uStageNumber�v��ۑ�
        PlayerPrefs.SetInt("STAGE", StageNumber);
        PlayerPrefs.Save();
        //�uTIME�v�Ƃ����L�[�ŁAInt�l�́uTimeCountint�v��ۑ�
        PlayerPrefs.SetInt("TIME", TimeCountint);
        PlayerPrefs.Save();
        //�uTIMEFLOAT�v�Ƃ����L�[�ŁAFloat�l�́uTimeCountint�v��ۑ�
        PlayerPrefs.SetFloat("TIMEFLOAT", timeCount);
        PlayerPrefs.Save();
        //�Q�[���N���A��ʂɈړ�
        SceneManager.LoadScene("GameClear");
    }
    private void GameOver_Drop()
    {
        //�uSTAGE�v�Ƃ����L�[�ŁAInt�l�́uStageNumber�v��ۑ�
        PlayerPrefs.SetInt("STAGE", StageNumber);
        PlayerPrefs.Save();
        //2022/12/19�@�V�[���؂�ւ����Ƀt�F�[�h�C���t�F�[�h�A�E�g�̉��o��ǉ�
        FadeManager.Instance.LoadScene("GameOver", 0.3f);
    }
   

}
