using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletdrop : MonoBehaviour
{
	public GameObject drop;
	//public float spawnTime;

	void Start(){
		SpawnBullet();
		StartCoroutine(DestroyBullet());

	}

	void Update()
	{
		transform.position = transform.position + Vector3.down * 5 * Time.deltaTime;
	}
	
	public void SpawnBullet(){
		GameObject.Instantiate(drop, new Vector3(Random.Range(-10, 10), 8, 0), Quaternion.identity);
	//	Invoke("SpawnBullet", spawnTime);
	}
	
	IEnumerator DestroyBullet() {
        yield return new WaitForSeconds(5);
		GameObject.Destroy(this.gameObject);
	}	
}