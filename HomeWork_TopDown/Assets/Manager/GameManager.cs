using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame

    // �̸��� ������������ �Լ�.
    private string playerName;
    public void SetPlayername(string name)
    {
        playerName = name;
    }

    public string GetstirngName()
    {
        return playerName;
    }
}
