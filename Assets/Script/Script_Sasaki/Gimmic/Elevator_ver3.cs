using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator_ver3 : MonoBehaviour
{
    //speed エレベーターの速さ startposition 始点 lastposition 終点
    public float speed;
    public float startposition;
    public float lastposition;
    private Vector3 pos;
    private bool isStop = false;
    public bool isStopAbilityElevator = false;
    //2022/11/27追加 ゲーム開始判定
    bool isStart = false;


    void Start()
    {
        pos = transform.position;
        isStopAbilityElevator = false;
        isStart = false;
    }

    void Update()
    {
        //2022/11/27追加 ゲーム開始判定
        //2022/11/23追加 ゲーム開始判定 全てのキー対応
        if (isStart == false && Input.anyKey)
        {
            isStart = true;
        }
        if (isStopAbilityElevator == true && isStart == true)
        {
            ElevatorMove();
        }
        else if (isStopAbilityElevator == false && isStart == true)
        {

        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) && isStart == true)
        {
            isStopAbilityElevator = false;
        }
        else if(isStart == true)
        {
            isStopAbilityElevator = true;
        }

    }
    private void ElevatorMove()
    {
        if (isStop == false)
        {
            pos.y += Time.deltaTime * speed;
            transform.position = pos;
            if (pos.y > lastposition)
            {
                isStop = true;
            }
        }
        else if (isStop == true)
        {
            pos.y -= Time.deltaTime * speed;
            transform.position = pos;
            if (pos.y < startposition)
            {
                isStop = false;
            }
        }
    }
}
