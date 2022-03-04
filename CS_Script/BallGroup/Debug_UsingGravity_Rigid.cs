using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debug_UsingGravity_Rigid : MonoBehaviour
{
    Rigidbody myRigid;
    // Start is called before the first frame update
    void Start()
    {
        myRigid = gameObject.GetComponent<Rigidbody>();
        //Debug.Log("is Using Gravity" + myRigid.useGravity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
