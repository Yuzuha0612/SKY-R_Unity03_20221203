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
    //2022/12/5追加　ボタンをキー選択させるため、最初に選択されるボタンををGameStartとしてFirstGameStartButtonに入れる
    [SerializeField] Button FirstGameStartButton;
    public void OnStartButtonClicked()
    {//試験開始ボタンを押すと最初から始めるボタンとステージ選択ボタン、戻るボタンが表示される
        StageSelectImage.enabled = true;
        StageSelectButton.enabled = true;
        StageSelectText.enabled = true;
        FirstStageButton.enabled = true;
        FirstStageImage.enabled = true;
        FirstStageText.enabled = true;
        ReturnButton.enabled = true;
        ReturnImage.enabled = true;
        ReturnText.enabled = true;
        //2022/12/5追加　ボタンをキー選択させるため、最初に選択されるボタンを指示する
        StageSelectButton.Select();
    }
    public void OnReturnButtonClicked()
    {//戻るボタンを押すと最初から始めるボタンとステージ選択ボタン、戻るボタンが非表示にされる
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
