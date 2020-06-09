using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girlheadcontroller : MonoBehaviour
{
    [SerializeField] GameObject loveBullet = null;
    public Animator girlhead;
    // Start is called before the first frame update
    void Start()
    {
        DelayedDestroy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DelayedDestroy()
    {
        GameObject.Instantiate(loveBullet);
        girlhead.SetTrigger("hasSpawned");
        yield return new WaitForSeconds(4.0f);
        Destroy(gameObject);


    }
}
