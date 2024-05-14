using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
   

    
   [SerializeField] private GameObject player;
  
    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        transform.Translate(0, 0, -10);
    }
}
