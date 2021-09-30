using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject playerObject;
    private Vector3 camOffset;
    // Start is called before the first frame update
    void Start()
    {
        camOffset = this.transform.position - playerObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = playerObject.transform.position + camOffset;
    }
}
