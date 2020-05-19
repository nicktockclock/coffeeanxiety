using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSprite : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rigid;
    void Start(){
        rigid = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate(){
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        //Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rigid.velocity = new Vector2(moveHorizontal*speed, moveVertical*speed);
    }
}
