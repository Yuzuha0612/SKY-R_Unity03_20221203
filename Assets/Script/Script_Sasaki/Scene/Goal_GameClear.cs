using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_GameClear : MonoBehaviour
{
    public bool isGameClear;
    void Start()
    {
        isGameClear = false;
    }
    //�S�[���ɂԂ�������S�[���V�[���Ɉړ�����
    private void OnCollisionEnter(Collision collision)
    {
        // �������������"Hasrtu"�^�O���t���Ă���ꍇ
        //TimeCount��GameClear_Time�����s���邽�߁AisGameClear��true�ɂ���
        if (collision.gameObject.tag == "Hasiru")
        {
            isGameClear = true;
        }
    }
}
