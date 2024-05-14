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
    

    //그전에 가져와야하는 함수
    

    //버튼 눌렸을때 함수
    public void OnButtonClicked()
    {
        //Debug.Log("Test");
        if (playerNameInput.text.Length > 2 && playerNameInput.text.Length <= 12)
        {
            if(SceneManager.GetActiveScene().name != "MainScene")
            {
                //Debug.Log("Test2");
                SceneManager.LoadScene("MainScene");
            }
            InputName();
        }
    }

    // 이름 변경위한 함수 
    private void InputName()
    {
        GameManager.instance.SetPlayername(playerNameInput.text);
    }
}


