using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletscript : MonoBehaviour
{
    private Vector2 movedirection;
    private float moveSpeed;
    private void OnEnable()
    {
        Invoke("OnDestroy", 6f);
    }
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movedirection * moveSpeed * Time.deltaTime);   
    }

    public void setMoveDirection(Vector2 dir)
    {
        movedirection = dir;
    }
    private void OnDestroy()
    {
        gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        CancelInvoke();
    }
}
