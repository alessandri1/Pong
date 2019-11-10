using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{

    public Transform paddle;
    public bool isStarted = false;
    public Rigidbody2D rb;
    public AudioSource ballAudio;
    float diff=0;
    // Start is called before the first frame update
    void Start()
    {
         diff = paddle.position.x - transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(!isStarted){
            
            transform.position = new Vector3(paddle.position.x - diff ,paddle.position.y,paddle.position.z);
            if(Input.GetMouseButtonDown(0))
            {
                isStarted =  true;
                rb.velocity = new Vector2(12,8);
             }
        }
    }
   private void OnCollisionEnter2D(Collision2D other) {
        ballAudio.Play();
    }
}
