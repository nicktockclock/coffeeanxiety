using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletfire : MonoBehaviour
{
    public WordHolder words;
    private string level;
    [SerializeField]
    private int bulletsamount = 10;

    [SerializeField]
    private float startangle = 359f, endangle = 180f;

    private Vector2 bulletmovedirection;




    // Start is called before the first frame update
    void Start()
    {
        level = "one";
        InvokeRepeating("Fire", 0f, 0.4f);    
    }

    private void Fire()
    {
        float angleStep = (endangle - startangle) / bulletsamount;
        float angle = startangle;
        var zAngle = Random.Range(60, 120);

        //for (int i = 0; i < bulletsamount + 1; i++)
        //{
        float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
        float bulDirY = transform.position.x + Mathf.Cos((angle * Mathf.PI) / 180f);

        Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
        Vector2 bulDir = (bulMoveVector - transform.position).normalized;

        GameObject bul = Bulletpoolscript.bulletpoolinstance.GetBullet(); //Retrieve a bullet, make it active and fly in the right direction. 
        if (Random.Range(0, 5)<4){
            bul.GetComponent<SpriteRenderer>().sprite = words.retrieveDamageWord(level);
            bul.tag = "badend";
        }
        else{
            bul.GetComponent<SpriteRenderer>().sprite = words.retrieveCorrectWord(level);
            bul.tag = "goodend";
        }
        
        bul.transform.position = transform.position;
        bul.transform.rotation = Quaternion.identity;
        bul.transform.Rotate(0, 0, Random.Range(60, 120), Space.Self);
        bul.SetActive(true);
        bul.GetComponent<Bulletscript>().setMoveDirection(bulDir);
        Destroy(bul.GetComponent<BoxCollider2D>());
        bul.AddComponent<BoxCollider2D>();
        angle += angleStep;
      //  }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
