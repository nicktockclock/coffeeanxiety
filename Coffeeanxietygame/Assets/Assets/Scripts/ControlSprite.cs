using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSprite : MonoBehaviour
{
    public WordHolder words;
    public Sprite[] faces;
    public SpriteRenderer face;
    public float speed;
    public int hp;
    private Rigidbody2D rigid;
    private SpriteRenderer sprite;
    private bool invincible;
    private float iframes;
    private string level;
    void Start(){
        rigid = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        invincible = false;
        face.sprite = faces[hp];
        level = "one";
    }

    void Update(){
        
    }

    void OnCollisionEnter2D(Collision2D collision){
        Debug.Log("Here I am + " + hp);
        if (!invincible && collision.gameObject.tag=="badend"){
            hp--;
            face.sprite = faces[hp];
            invincible = true;
            iframes = 2.0f;
            StartCoroutine(InvincibilityFrames());
            collision.gameObject.SetActive(false);
        }
        else if(collision.gameObject.tag=="goodend"){
            collision.gameObject.SetActive(false);
            words.incrementcurrent(level);
        }
    }

    void FixedUpdate(){
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
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
        sprite.enabled = true;
    }

    void Flicker(){
        Debug.Log(iframes);
        sprite.enabled = !sprite.isVisible;
    }
}
