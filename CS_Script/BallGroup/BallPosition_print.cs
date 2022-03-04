using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPosition_print : MonoBehaviour
{
    float startPos;
    float curPos;
    // Start is called before the first frame update
    void Start()
    {
           startPos = gameObject.transform.position.y;
    }
    bool overTheLine = true;
    // Update is called once per frame
    void Update()
    {
        curPos = gameObject.transform.position.y;
        if(((startPos - curPos) >= 3.0f) && overTheLine){
            overTheLine = false;
            Debug.Log("overTheLine" + (startPos - curPos));
        }
    }
}
