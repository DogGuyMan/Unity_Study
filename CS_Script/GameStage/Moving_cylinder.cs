using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Moving_cylinder : MonoBehaviour
{
    public float cylPos = 0.0f; 
    public float cylSpeed = 0.05f;
    public Boolean randomUse;
    
    float delta;
    float cylX;
    float cylY;
    float nextZ;
    int[] NePoArr = {-1,1};
    // Start is called before the first frame update
    void Start()
    {
        cylX = transform.localPosition.x;
        cylY = transform.localPosition.y;
        if(randomUse){
            cylPos = UnityEngine.Random.Range(-0.47f, 0.47f);
            nextZ = transform.localPosition.z + cylPos;

        }
        else{
            nextZ = transform.localPosition.z;            
        }
        System.Random rand = new System.Random();
        int randomIndex = rand.Next(0,1);
        delta = (float)NePoArr[randomIndex] * cylSpeed;
        this.transform.localPosition = new Vector3(cylX, cylY,nextZ);
    }

    // Update is called once per frame
   void Update()
    {
        if(transform.localPosition.z < -0.47f){
            delta = 1f * cylSpeed;
        }
        else if(transform.localPosition.z > 0.47f){
            delta = -1f * cylSpeed;
        }
        nextZ = transform.localPosition.z + delta;
        this.transform.localPosition = new Vector3(cylX, cylY, nextZ);
    }
}
