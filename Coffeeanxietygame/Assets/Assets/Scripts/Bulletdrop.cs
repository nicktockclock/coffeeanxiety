using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletdrop : MonoBehaviour
{
	public GameObject drop;
	//public float spawnTime;

	void Start(){
		StartCoroutine(DestroyBullet());

	}

	void Update()
	{
		transform.position = transform.position + Vector3.down * 5 * Time.deltaTime;
	}
	
	IEnumerator DestroyBullet() {
        yield return new WaitForSeconds(5);
		GameObject.Destroy(this.gameObject);
	}	
}