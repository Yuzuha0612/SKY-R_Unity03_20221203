using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OperationSelect : MonoBehaviour
{
    [SerializeField] Image ExplanationImage;
    [SerializeField] Button ExplanationCloseButton;
    [SerializeField] Button ExplanationCloseAndFirstStageButton;
    [SerializeField] Image ExplanationCloseAndFirstStageImage;
    [SerializeField] Image ExplanationImageCloseButton;
    [SerializeField] RawImage ExplanationMovieWalk;
    [SerializeField] RawImage ExplanationMovieJump;
    [SerializeField] Text ExplanationTextWalk;
    [SerializeField] Text ExplanationTextJump;
    public void OnOperationExplanationButtonClicked()
    {//操作説明ボタンを押すと操作説明画像が表示される
        ExplanationImage.enabled = true;
        ExplanationCloseButton.enabled = true;
        ExplanationImageCloseButton.enabled = true;
        ExplanationMovieWalk.enabled = true;
        ExplanationMovieJump.enabled = true;
        ExplanationTextWalk.enabled = true;
        ExplanationTextJump.enabled = true;
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
    }

    public void OnOperationExplanationButtonAndFirstStageClicked()
    {//最初から始めるを押すと操作説明画像が表示される
        ExplanationImage.enabled = true;
        ExplanationCloseButton.enabled = true;
        ExplanationCloseAndFirstStageButton.enabled = true;
        ExplanationCloseAndFirstStageImage.enabled = true;
        ExplanationMovieWalk.enabled = true;
        ExplanationMovieJump.enabled = true;
        ExplanationTextWalk.enabled = true;
        ExplanationTextJump.enabled = true;
    }
    public void OnOperationExplanationButtonOffAndFirstStageClicked()
    {//×ボタンを押すと操作説明画像が非表示にされる
        //最初のステージに進む
        ExplanationImage.enabled = false;
        ExplanationCloseButton.enabled = false;
        ExplanationCloseAndFirstStageButton.enabled = false;
        ExplanationCloseAndFirstStageImage.enabled = false;
        ExplanationMovieWalk.enabled = false;
        ExplanationMovieJump.enabled = false;
        ExplanationTextWalk.enabled = false;
        ExplanationTextJump.enabled = false;
        SceneManager.LoadScene("Stage0");
    }
}
