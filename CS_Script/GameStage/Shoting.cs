using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoting : MonoBehaviour
{
    public GameObject GenOb;
    float timeCount = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        if(timeCount > 3){
            Instantiate(GenOb, transform.position, Quaternion.identity);
            timeCount = 0;
        }
    }
}
