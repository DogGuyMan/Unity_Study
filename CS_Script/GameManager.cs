using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool DEBUG = true;
    private int coinCount = 0;
    public Text coinText;
    public void CalCoin(){
        coinCount++;
    }
    public void RestartGame(){
        if(DEBUG) {Debug.Log("Total Coins" + coinCount);}
        Application.LoadLevel("BallGame");
        if(DEBUG) {Debug.Log("Restarted");}
    }
    public void DestroyObstacleWithTarget(string _Target){
        GameObject[] ObstaclesArr = GameObject.FindGameObjectsWithTag(_Target);
        foreach(GameObject E in ObstaclesArr){
            Destroy(E);
        }
        if(DEBUG) {Debug.Log("Get RedCoin Remove All");}
    }
    public void DrawText(){
        coinText.text = $"Coin : {coinCount}";
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
