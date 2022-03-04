using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclPower : MonoBehaviour
{
    public float collisionPower;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision _collision)
    {
        Vector3 direction = _collision.gameObject.transform.position - transform.position;
        direction = direction.normalized * collisionPower;
        _collision.gameObject.GetComponent<Rigidbody>().AddForce(direction);

    }
}
