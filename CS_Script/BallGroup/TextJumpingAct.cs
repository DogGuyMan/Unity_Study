using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextJumpingAct : MonoBehaviour
{
    private float time_start;
    private float time_current;
    // Start is called before the first frame update
    public float exposeTime;
    
    void Start()
    {
        transform.GetChild(1).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true){
           StartCoroutine(DrawText());
        }
    }
    IEnumerator DrawText()
    {
        transform.GetChild(1).gameObject.SetActive(true);
        yield return new WaitForSeconds(exposeTime);
        transform.GetChild(1).gameObject.SetActive(false);
    }
}
