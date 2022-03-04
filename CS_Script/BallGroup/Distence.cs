using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distence : MonoBehaviour
{
    bool DEBUG = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TragetDist("Text (TMP)");
    }
    void TragetDist(string _Target){
        if(GameObject.Find(_Target) != null){
            float thisToTargetDist = Vector3.Distance(
                GameObject.Find(_Target).transform.position, 
                transform.position
            );
            if(DEBUG) {Debug.Log(_Target + " To " + this.gameObject.ToString() + thisToTargetDist);}
        }
    }
}
