using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_Col_grow : MonoBehaviour
{
    // Start is called before the first frame update
    SphereCollider myColliderRadius;
    // Start is called before the first frame update
    void Start()
    {
        myColliderRadius = gameObject.GetComponent<SphereCollider>();
    }   

    // Update is called once per frame
    void Update()
    {
        myColliderRadius.radius += 0.01f;
        Debug.Log(myColliderRadius.radius);
    }
}
