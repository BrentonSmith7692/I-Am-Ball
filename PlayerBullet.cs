using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour 
{
	public float speed;
	public GameObject LightningBolt;
	// Use this for initialization
	void Start () 
	{
		speed = 30f;
	}
	
	// Update is called once per frame
	void Update () 
	{
			transform.Translate(Vector3.right * speed * Time.deltaTime);
	}
	
	void OnBecameInvisible () {
		this.gameObject.SetActive(false);
	}
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "EnemyTag")
			Destroy(gameObject);
	}
}