using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoin : MonoBehaviour
{
    private GameManager worldGM;
    public GameObject G;
    void OnTriggerEnter(Collider _col){
        if(_col.gameObject.name == "Ball"){
            worldGM.CalCoin();
            worldGM.DrawText();
            //Debug.Log(gameObject.name +" " + gameObject.tag);
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        worldGM = G.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
