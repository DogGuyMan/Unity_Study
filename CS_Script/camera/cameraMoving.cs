using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMoving : MonoBehaviour
{
    GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
        transform.rotation = Quaternion.Euler(new Vector3(30f, -30f, 0.0f));
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            ball.transform.position.x + (5 * Mathf.Cos(Mathf.PI/6 * 5) * Mathf.Sin(-Mathf.PI/6)),
            ball.transform.position.y + 5 * (Mathf.Sin(Mathf.PI/6 * 5)),
            ball.transform.position.z + 5 * (Mathf.Cos(Mathf.PI/6 * 5)) + (Mathf.Cos(Mathf.PI/6 * 5) * Mathf.Cos(-Mathf.PI/6)) 
            );
    }
}
