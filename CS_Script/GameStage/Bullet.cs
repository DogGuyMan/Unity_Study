using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject GM;
    public GameObject target;
    private GameManager worldGM;
    private Vector3 targetPos;
    private void OnCollisionEnter(Collision _col) {
        if(_col.gameObject.name == target.name){
            Destroy(gameObject);
            worldGM.RestartGame();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        worldGM = GM.GetComponent<GameManager>();
        targetPos = target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        targetPos = target.transform.position;
        transform.Rotate(new Vector3(0,0,5));
        transform.position = Vector3.MoveTowards(transform.position, targetPos, 0.1f);
    }

}
