using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame_Button : MonoBehaviour
{
    //背景
    [SerializeField] Image EndGameWarningImage;
    //いいえボタン
    [SerializeField] Button EndGameWarningCloseButton;
    [SerializeField] Image EndGameWarningCloseImage;
    [SerializeField] Text EndGameWarningCloseText;
    //ゲーム終了しますかテキスト
    [SerializeField] Text EndGameWarningText;
    //はいボタン
    [SerializeField] Button EndGameButton;
    [SerializeField] Image EndGameImage;
    [SerializeField] Text EndGameText;
    public void OnEndGameFirstButtonClicked()
    {//最初にゲーム終了ボタンを押すとゲーム終了警告画面が表示される
        EndGameWarningImage.enabled = true;
        EndGameWarningText.enabled = true;
        EndGameWarningCloseButton.enabled = true;
        EndGameWarningCloseImage.enabled = true;
        EndGameWarningCloseText.enabled = true;
        EndGameButton.enabled = true;
        EndGameImage.enabled = true;
        EndGameText.enabled = true;
    }

    public void OnEndGameSecondButtonOffClicked()
    {//はいを押すとゲームを終了する
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
    Application.Quit();//ゲームプレイ終了
#endif
    }
    public void OnEndGameWarningButtonOffClicked()
    {//いいえを押すとステージ選択画面に戻る
        EndGameWarningImage.enabled = false;
        EndGameWarningText.enabled = false;
        EndGameWarningCloseButton.enabled = false;
        EndGameWarningCloseImage.enabled = false;
        EndGameWarningCloseText.enabled = false;
        EndGameButton.enabled = false;
        EndGameImage.enabled = false;
        EndGameText.enabled = false;
    }
}
