using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatapataRotate : MonoBehaviour
{//�v���y�����񂷃X�N���v�g�ł��A�v���y���̒��S�ɐݒu����PatapataPuroperaAll�Ɏ��t���Ă�������
    public float RotatePataPata;
    public bool isStopAbilityPatapataPropeller;
    private bool isStop = false;
    bool isStart = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isStart == false && Input.anyKey)
        {
            isStart = true;
        }
        if (isStopAbilityPatapataPropeller == true && isStart == true)
        {
            PatapataPropellerMove();
        }
        else if (isStopAbilityPatapataPropeller == false && isStart == true)
        {

        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) && isStart == true)
        {
            isStopAbilityPatapataPropeller = false;
        }
        else
        {
            isStopAbilityPatapataPropeller = true;
        }

    }
    void PatapataPropellerMove()
        {
        gameObject.transform.Rotate(new Vector3(0, RotatePataPata, 0) * Time.deltaTime);
    }
}
