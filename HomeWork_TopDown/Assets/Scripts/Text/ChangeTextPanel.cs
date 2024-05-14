using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTextPanel : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject Panelobject;

    public void OnBtnClick()
    {
        Instantiate(Panelobject);
    }
}
