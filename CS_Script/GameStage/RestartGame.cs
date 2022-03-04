using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGame : MonoBehaviour
{
    bool DEBUG = false;
    private GameManager worldGM;
    public GameObject G;
    void OnTriggerEnter(Collider _collider) {
        if(DEBUG) {Debug.Log(_collider.gameObject.name);}
        if(_collider.gameObject.name == "Ball"){
            worldGM.RestartGame();
            //Application.LoadLevel("BallGame");
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
