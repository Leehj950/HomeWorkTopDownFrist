using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelButton : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject playerObject;
    SpriteRenderer sprite;
    Image image;
    // Start is called before the first frame update
    private void Awake()
    {
        image = GetComponent<Image>();
        sprite = playerObject.GetComponentInChildren<SpriteRenderer>();
        GameManager.instance.SetPlayerGameObject(playerObject);
    }
    private void Start()
    {
        GameManager.instance.SetSpriteRenderer(sprite.sprite);
    }

    private void Update()
    {
        image.sprite = GameManager.instance.GetSpriteRenderer();
    }

    public void OnBtnClick()
    {
        Instantiate(panel);   
    }
}
