using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameButton : MonoBehaviour
{
    public InputField playerNameInput;
    private string playerName = null;

    //그전에 가져와야하는 함수
    private void Awake()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
    }

    //버튼 눌렸을때 함수
    public void OnButtonClicked()
    {
        Debug.Log("Test");
        if (playerNameInput.text.Length > 2 && playerNameInput.text.Length <= 12)
        {
            InputName();
            if(SceneManager.GetActiveScene().name != "MainScene")
            {
                Debug.Log("Test2");
                SceneManager.LoadScene("MainScene");
            }
        }
    }

    // 이름 변경위한 함수 
    private void InputName()
    {
        GameManager.instance.SetPlayername(playerNameInput.text);
    }
}
