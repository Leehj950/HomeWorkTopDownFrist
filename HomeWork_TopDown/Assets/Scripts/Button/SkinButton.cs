using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SkinButton : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject Panel;
    private SpriteRenderer spriteRenderer;
    private Image image;

    private void Awake()
    {
       
        spriteRenderer = player.GetComponentInChildren<SpriteRenderer>();
        image = GetComponent<Image>();
    }

    private void Start()
    {
        image.sprite = spriteRenderer.sprite;
    }

    public void OnBtnClick()
    {
        GameManager.instance.SetSpriteRenderer(image.sprite);
        GameManager.instance.SetPlayerGameObject(player);
        Destroy(Panel);
    }
}
