using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver_Drop : MonoBehaviour
{
    public bool isGameOver;
    void Start()
    {
        isGameOver = false;
    }
    //�S�[���ɂԂ�������S�[���V�[���Ɉړ�����
    private void OnCollisionEnter(Collision collision)
    {
        // �������������"Hasrtu"�^�O���t���Ă���ꍇ
        //TimeCount��GameOver_Time�����s���邽�߁AisGameOver��true�ɂ���
        if (collision.gameObject.tag == "Hasiru")
        {
            isGameOver = true;
        }
    }
}
