using UnityEngine;
using System.Collections;

public class EnemyDeath : MonoBehaviour {

	public GameObject Turntable;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "PlayerBulletTag")
			Destroy (gameObject);
        else if (col.tag == "PlayerTag")
            Application.LoadLevel(Application.loadedLevel);
    }

}
