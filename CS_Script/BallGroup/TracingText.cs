using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracingText : MonoBehaviour
{
    public Camera cameraToLookAt;
    public GameObject G;
    // Start is called before the first frame update
    void Start()
    {
        cameraToLookAt = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            G.transform.position.x + (8.5f *Mathf.Sin(cameraToLookAt.transform.localEulerAngles.y)),
            G.transform.position.y,
            G.transform.position.z + (8.5f *Mathf.Cos(cameraToLookAt.transform.localEulerAngles.y))
        );
    }
    
}
