using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OperationSelectOption : MonoBehaviour
{
    [SerializeField] Image ExplanationImage;
    [SerializeField] Button ExplanationCloseButton;
    [SerializeField] Image ExplanationImageCloseButton;
    [SerializeField] RawImage ExplanationMovieWalk;
    [SerializeField] RawImage ExplanationMovieJump;
    [SerializeField] Text ExplanationTextWalk;
    [SerializeField] Text ExplanationTextJump;
    //2022/12/5追加　ボタンをキー選択させるため、最初に選択されるボタンをGameStartとしてFirstGameStartButtonに入れる
    [SerializeField] Button FirstGameStartButton;

    public void OnOperationExplanationButtonClicked()
    {//操作説明ボタンを押すと操作説明画像が表示される
        ExplanationImage.enabled = true;
        ExplanationCloseButton.enabled = true;
        ExplanationImageCloseButton.enabled = true;
        ExplanationMovieWalk.enabled = true;
        ExplanationMovieJump.enabled = true;
        ExplanationTextWalk.enabled = true;
        ExplanationTextJump.enabled = true;
        //2022/12/5追加　ボタンをキー選択させるため、×ボタンを選択する
        ExplanationCloseButton.Select();
    }

    public void OnOperationExplanationButtonOffClicked()
    {//×ボタンを押すと操作説明画像が非表示にされる
        ExplanationImage.enabled = false;
        ExplanationCloseButton.enabled = false;
        ExplanationImageCloseButton.enabled = false;
        ExplanationMovieWalk.enabled = false;
        ExplanationMovieJump.enabled = false;
        ExplanationTextWalk.enabled = false;
        ExplanationTextJump.enabled = false;
        //2022/12/5追加　ボタンをキー選択させるため、最初に選択されるボタンを指示する
        FirstGameStartButton.Select();
    }
}

