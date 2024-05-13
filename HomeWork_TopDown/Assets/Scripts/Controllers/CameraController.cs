using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
   

    
    public GameObject player;
    Transform objtransform;

    private void Start()
    {
        objtransform = player.transform;
    }

    void Update()
    {
        transform.position = new Vector3(objtransform.position.x, objtransform.position.y, objtransform.position.z);
        transform.Translate(0, 0, -10);
    }
}
