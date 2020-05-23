using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSprite : MonoBehaviour
{
    public float speed;
    public int hp;
    private Rigidbody2D rigid;
    private SpriteRenderer sprite;
    private bool invincible;
    private float iframes;
    void Start(){
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        invincible = false;
    }

    void Update(){
        
    }

    void OnCollisionEnter2D(Collision2D collision){
        Debug.Log("Here I am + " + hp);
        if (!invincible){
            hp--;
            invincible = true;
            iframes = 2.0f;
            StartCoroutine(InvincibilityFrames());
            if (collision.gameObject.tag=="badend"){
                collision.gameObject.SetActive(false);
            }
        }
    }

    void FixedUpdate(){
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        //Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rigid.velocity = new Vector2(moveHorizontal*speed, moveVertical*speed);
    }

    IEnumerator InvincibilityFrames(){
        while (invincible){
            yield return new WaitForSeconds(0.2f);
            iframes-=0.2f;
            if (iframes<=0.0f){
                invincible = false;
            }
            Flicker();
        }
    }

    void Flicker(){
        Debug.Log(iframes);
        sprite.enabled = !sprite.isVisible;
    }
}
