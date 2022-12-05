using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public GameObject Sabodon;
    void Start()
    {
        timeCount = 10;
        timeLabel.text = "TIME:" + timeCount; //fixapdate
        GoalObject = GameObject.FindGameObjectWithTag("Goal");
        GameOverArea = GameObject.FindGameObjectWithTag("GameOverArea");
        Sabodon = GameObject.FindGameObjectWithTag("TogeToge");
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
            //���E�L�[�̂ǂ��炩�������ꂽ�Ƃ����Ԃ������̂��~�߂邻��ȊO��TimedeltaTime�Ŏ��Ԍo��
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) && Sabodon.GetComponent<Sabodon>().isTogeDamege)
            {
                timeLabel.text = "TIME:" + timeCount.ToString("0.00");
            }
            else 
            {
                timeCount -= Time.deltaTime;
                timeLabel.text = "TIME:" + timeCount.ToString("0.00");
            }
        }
        if (timeCount < 0)
        {//2022/11/27�ǉ��@�Q�[���I�[�o�[���猻�݂̃X�e�[�W�ɖ߂��Ă���
            //0�b�ȉ��ɂȂ�����
            //�uSTAGE�v�Ƃ����L�[�ŁAInt�l�́uStageNumber�v��ۑ�
            PlayerPrefs.SetInt("STAGE", StageNumber);
            PlayerPrefs.Save();
            //�Q�[���I�[�o�[��ʂɈړ�
            SceneManager.LoadScene("GameOver");
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
        //�Q�[���I�[�o�[��ʂɈړ�
        SceneManager.LoadScene("GameOver");
    }

}
