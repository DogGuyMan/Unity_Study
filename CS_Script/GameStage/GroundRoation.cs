using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRoation : MonoBehaviour
{
    float curX;float curY;float curZ;
    public Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        curX = tr.localEulerAngles.x;
        curY = tr.localEulerAngles.y;
        curZ = tr.localEulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        float rotA = tr.localEulerAngles.x;
        rotA += Input.GetAxis("Horizontal");
        tr.rotation = Quaternion.Euler(rotA, curY, curZ);

        if(Input.touchCount > 0 || Input.GetMouseButton(0)){
            if(Input.mousePosition.x < Screen.width / 2f){
                tr.rotation = Quaternion.Euler(tr.localEulerAngles.x-1, curY, curZ);
            }
            else if (Input.mousePosition.x >= Screen.width / 2f){
                tr.rotation = Quaternion.Euler(tr.localEulerAngles.x+1, curY, curZ);
            }
        }
    }
}
