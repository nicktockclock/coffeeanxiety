using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletfire : MonoBehaviour
{
    [SerializeField]
    private int bulletsamount = 10;

    [SerializeField]
    private float startangle = 359f, endangle = 180f;

    private Vector2 bulletmovedirection;




    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 0f, 2f);    
    }

    private void Fire()
    {
        float angleStep = (endangle - startangle) / bulletsamount;
        float angle = startangle;

        for (int i = 0; i < bulletsamount + 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bulDirY = transform.position.x + Mathf.Cos((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = Bulletpoolscript.bulletpoolinstance.GetBullet(); //Retrieve a bullet, make it active and fly in the right direction. 
            bul.transform.position = transform.position;
            bul.transform.Rotate(0, 0, 90, Space.Self);
            bul.SetActive(true);
            bul.GetComponent<Bulletscript>().setMoveDirection(bulDir);

            angle += angleStep;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
