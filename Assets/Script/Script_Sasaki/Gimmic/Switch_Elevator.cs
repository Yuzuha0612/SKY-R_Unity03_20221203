using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Elevator : MonoBehaviour
{
    //Elevator01最初のエレベーター、Elevator02切り替え後のエレベーター
    public GameObject Elevator01;
    public GameObject Elevator02;
    public bool isElevatorSwitch;
    void Start()
    {
        isElevatorSwitch = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        //Debug.Log("エレベーター切り替え");
        if (collision.gameObject.CompareTag("Hasiru"))
        {
            //Debug.Log("エレベーター切り替え");
            Elevator01.gameObject.SetActive(false);
            Elevator02.gameObject.SetActive(true);
            isElevatorSwitch = true;

        }
    }
}
