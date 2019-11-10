using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scorePlayerText;
    public Text scoreEnemyText;
    public AudioSource audioPoint;

    int scorePlayerQuantity=0;
    int scoreEnemyQuantity=0;

    public Scene sceneChanger;

    private void OnTriggerEnter2D(Collider2D ball) {
    audioPoint.Play();

    if(gameObject.tag.Equals("right")){
        scorePlayerQuantity++;
        UpdateScore(scorePlayerText, scorePlayerQuantity);
        
    } else if(gameObject.tag.Equals("left")){
        scoreEnemyQuantity++;
        UpdateScore(scoreEnemyText, scoreEnemyQuantity);
        
    }
    checkScore();
    ball.GetComponent<BallBehaviour>().isStarted = false;


    }

    void UpdateScore(Text scoreText, int quantity){
        scoreText.text = quantity.ToString(); 
    }
    void checkScore(){
        if(scorePlayerQuantity>=3)
        {
            sceneChanger.sceneChange("Win");
        } else if(scoreEnemyQuantity>=3){
            sceneChanger.sceneChange("Lose");
        }
    }
}
