using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girlheadcontroller : MonoBehaviour
{
    public GameObject loveBullet;
    public Animator girlhead;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Shoot(){
        GameObject heart = Instantiate (loveBullet);
        girlhead.SetTrigger("hasSpawned");
        heart.transform.position = transform.position;
    }
}
