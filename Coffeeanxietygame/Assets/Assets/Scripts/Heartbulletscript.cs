using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heartbulletscript : MonoBehaviour
{
    private Vector2 target = new Vector2();
    [SerializeField] private float speed = 8;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("brainsprite").transform.position;
        Vector2 direction = (target - (Vector2)transform.position);

        float angle = 0;
        if (direction.x > 0)
            angle = 90 - Mathf.Acos(direction.x / direction.magnitude) / Mathf.PI * 180.0f;
        else
            angle = (Mathf.Acos(-direction.x / direction.magnitude) / Mathf.PI * 180.0f - 90);

        transform.rotation = Quaternion.Euler(0, 0, -angle);
        StartCoroutine(DestroyMe());
    }

    // Update is called once per frame
    void Update()
    {
        //Moves missile towards target until it hits it. 
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

    }
    IEnumerator DestroyMe(){
        yield return new WaitForSeconds(3f);
        Destroy(this.gameObject);
    }
}
