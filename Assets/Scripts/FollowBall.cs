using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public Transform ball;
    public float speed;
    
    // Update is called once per frame
    void Start(){
        speed = Random.Range(0.10f, 0.15f);
    }
    void Update()
    {
        if(ball.GetComponent<BallBehaviour>().isStarted){
            if(ball.position.y > transform.position.y)
            transform.position = new Vector3(transform.position.x,transform.position.y+speed,transform.position.z);
            else if(ball.position.y < transform.position.y)
            transform.position = new Vector3(transform.position.x,transform.position.y-speed,transform.position.z);
    }}
}
