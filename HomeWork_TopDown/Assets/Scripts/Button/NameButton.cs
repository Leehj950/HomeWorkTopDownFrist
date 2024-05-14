using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameButton : MonoBehaviour
{
    [SerializeField] private InputField playerNameInput;
    [SerializeField] private GameObject panel;

    //������ �����;��ϴ� �Լ�


    //��ư �������� �Լ�
    public void OnButtonClicked()
    {
        //Debug.Log("Test");
        if (playerNameInput.text.Length > 2 && playerNameInput.text.Length <= 12)
        {
            InputName();
            if (SceneManager.GetActiveScene().name != "MainScene")
            {
                //Debug.Log("Test2");
                SceneManager.LoadScene("MainScene");
            }
            Destroy(panel);
        }
    }

    // �̸� �������� �Լ� 
    private void InputName()
    {
        GameManager.instance.SetPlayername(playerNameInput.text);
    }
}


