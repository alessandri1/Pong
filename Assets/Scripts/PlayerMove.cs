using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Variable de la posicion del mouse
        if(mousePos.y > 3.9f)  mousePos.y = 3.9f;
        if(mousePos.y < -3.9f)  mousePos.y = -3.9f;
        transform.position = new Vector3(transform.position.x,mousePos.y,transform.position.z);
    }
}
