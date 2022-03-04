using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateLight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.captureFramerate = 60;
    }
    // Update is called once per frame
    public float inputSpeed;
    void Update()
    {
        transform.Rotate(Vector3.right, (inputSpeed) * Time.deltaTime);
    }
}
