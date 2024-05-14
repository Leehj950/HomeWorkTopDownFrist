using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    private Sprite sprite;
    private string playerName;
    private GameObject PlayergameObject;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    // ������ �Ŵ����� ���ؼ� �������� �ʾ�����?
    // �̸��� ������������ �Լ�.
    public void SetPlayername(string name)
    {
        playerName = name;
    }

    public string GetPlayerName()
    {
        return playerName;
    }
    
    public void SetSpriteRenderer (Sprite value)
    {
        this.sprite = value;
    }

    public Sprite GetSpriteRenderer()
    {
        return sprite; 
    }

    public void SetPlayerGameObject(GameObject gameObject)
    {
        PlayergameObject = gameObject;
    }

    public void PlayerCreate()
    {
        Instantiate(PlayergameObject);
    }


}
