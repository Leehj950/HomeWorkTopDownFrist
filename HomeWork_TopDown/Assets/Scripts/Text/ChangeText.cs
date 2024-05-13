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
    [SerializeField] Transform transform;
    private void Awake()
    {
        nametext = GetComponent<Text>();
        transform = GetComponent<Transform>();
    }



    private void Update()
    {
        TextChange();
    }

    public void TextChange()
    {
        nametext.text = GameManager.instance.GetstirngName();
        this.transform.position = transform.position;
    }

}
