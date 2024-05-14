using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


public class ChangeText : MonoBehaviour
{
    [SerializeField] Text nametext;
    private void Awake()
    {
        nametext = GetComponent<Text>();
    }
    private void Update()
    {
        TextChange();
    }
    public void TextChange()
    {
        nametext.text = GameManager.instance.GetPlayerName();
        this.transform.position = transform.position;
    }

}
