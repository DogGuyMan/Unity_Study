using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_Colider : MonoBehaviour
{
    SphereCollider myColliderRadius;
    public float inPutRadius = 0;
    // Start is called before the first frame update
    void Start()
    {
        myColliderRadius = gameObject.GetComponent<SphereCollider>();
        myColliderRadius.radius += inPutRadius; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
