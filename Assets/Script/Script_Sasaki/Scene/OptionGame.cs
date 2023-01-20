using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionGame : MonoBehaviour
{
    //オプションを表示させる
    [SerializeField] Image VolumeControlButtonImage;
    [SerializeField] Image OperationButtonButtonImage;
    [SerializeField] Image EndGameButtonButtonImage;
    [SerializeField] Image OptionCloseButtonImage;
    [SerializeField] Image OptionBackgroundImage;
   // [SerializeField] Image BackgroundGray;
    [SerializeField] Button VolumeControlButton;
    [SerializeField] Button OperationButton;
    [SerializeField] Button EndGameButton;
    [SerializeField] Text OptionCloseButtonTextImage;
    [SerializeField] Text VolumeControlButtonButtonText;
    [SerializeField] Text OperationButtonText;
    [SerializeField] Text EndGameButtonButtonText;
    [SerializeField] Text OptionText;
    [SerializeField] Text MouseRevivalText;
    [SerializeField] Text OperationEscText;
    [SerializeField] Button OperationCloseAfterButton;
    private bool EscapeKeyClick;
    void Update()
    {
        if ((Input.GetMouseButtonDown(0)) && (VolumeControlButton.enabled == true))
        {
            VolumeControlButton.Select();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Debug.Log("オプション選択");
                VolumeControlButtonImage.enabled = true;
                OperationButtonButtonImage.enabled = true;
                EndGameButtonButtonImage.enabled = true;
                VolumeControlButton.enabled = true;
                OperationButton.enabled = true;
                EndGameButton.enabled = true;
                VolumeControlButtonButtonText.enabled = true;
                OperationButtonText.enabled = true;
                EndGameButtonButtonText.enabled = true;
                OptionCloseButtonImage.enabled = true;
            OptionCloseButtonTextImage.enabled = true;
                OptionBackgroundImage.enabled = true;
                OptionText.enabled = true;
            MouseRevivalText.enabled = true;
            //BackgroundGray.enabled = true;
            OperationEscText.enabled = false;
            VolumeControlButton.Select();
                // 移動＆時間無効
                GameObject Hasiru1 = GameObject.FindGameObjectWithTag("Hasiru");
                Hasiru1.gameObject.GetComponent<Hasiru_Move>().enabled = false;
                GameObject Camera1 = GameObject.FindGameObjectWithTag("MainCamera");
                Camera1.gameObject.GetComponent<Timecounte>().enabled = false;
            }
            if (Input.GetKeyDown(KeyCode.F1))
            {
                Debug.Log("オプション解除");
                VolumeControlButtonImage.enabled = false;
                OperationButtonButtonImage.enabled = false;
                EndGameButtonButtonImage.enabled = false;
                VolumeControlButton.enabled = false;
                OperationButton.enabled = false;
                EndGameButton.enabled = false;
                VolumeControlButtonButtonText.enabled = false;
                OperationButtonText.enabled = false;
                EndGameButtonButtonText.enabled = false;
                OptionCloseButtonImage.enabled = false;
            OptionCloseButtonTextImage.enabled = false;
                OptionBackgroundImage.enabled = false;
                OptionText.enabled = false;
            MouseRevivalText.enabled = false;
            //BackgroundGray.enabled = false;
            OperationEscText.enabled = true;
            // 移動＆時間無効
            GameObject Hasiru1 = GameObject.FindGameObjectWithTag("Hasiru");
                Hasiru1.gameObject.GetComponent<Hasiru_Move>().enabled = true;
                GameObject Camera1 = GameObject.FindGameObjectWithTag("MainCamera");
                Camera1.gameObject.GetComponent<Timecounte>().enabled = true;
            }
        }

        /*
        if (Input.GetKeyDown(KeyCode.Escape) && VolumeControlButtonImage == true)
        {
            Debug.Log("オプション解除" );
            VolumeControlButtonImage.enabled = false;
            OperationButtonButtonImage.enabled = false;
            EndGameButtonButtonImage.enabled = false;
            VolumeControlButton.enabled = false;
            OperationButton.enabled = false;
            EndGameButton.enabled = false;
            VolumeControlButtonButtonText.enabled = false;
            OperationButtonText.enabled = false;
            EndGameButtonButtonText.enabled = false;
            OptionCloseButtonImage.enabled = false;
            OptionCloseButton.enabled = false;
            OptionBackgroundImage.enabled = false;
            OptionText.enabled = false;
           
            OperationCloseAfterButton.Select();
        }*/
    
    public void OnOptionCloseClicked()
    {
      
    }
    }
