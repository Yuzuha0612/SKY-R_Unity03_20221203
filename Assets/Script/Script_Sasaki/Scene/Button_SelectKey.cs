using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_SelectKey : MonoBehaviour
{//ボタンをキー選択させるため、最初に選択されるキーを指示する
    public Button FirstButton;
    void Start()
    {
       // Firstbutton = GameObject.Find("Canvas/Button/").GextComponent<Button>();
      FirstButton.Select();
    }

}
