using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeBallJump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true){
            GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
        }
    }
}
