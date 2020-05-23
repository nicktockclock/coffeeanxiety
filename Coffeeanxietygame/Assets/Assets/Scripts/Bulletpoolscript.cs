using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletpoolscript : MonoBehaviour
{
    public static Bulletpoolscript bulletpoolinstance;

    [SerializeField]
    private GameObject pooledBullet;
    private bool notEnoughBulletsInPool = true;

    private List<GameObject> bullets;
    private void Awake()
    {
        bulletpoolinstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        bullets = new List<GameObject>();
    }

    public GameObject GetBullet()
    {
        if (bullets.Count > 0)
        {
            for (int i = 0; i < bullets.Count; i++)
            {
                if (!bullets[i].activeInHierarchy) //If an inactive bullet is found, return it. 
                {
                    return bullets[i];
        
                }
            }
        }
        if (notEnoughBulletsInPool)
        {
            GameObject bul = Instantiate(pooledBullet);
            bul.SetActive(false);
            var zAngle = Random.Range(60, 120);
            bul.transform.Rotate(0, 0, zAngle, Space.Self);
            bullets.Add(bul);
            return (bul);
        }

        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
