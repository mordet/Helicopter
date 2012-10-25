using UnityEngine;
using System.Collections;

public class destroybelObject : MonoBehaviour {
	
	public float health=1;
	
	private Animation anim = null;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void reduceHealth(int damage) {
 		if (health <= 0)
			return;
		
		health -= damage;
		if (health <= 0) {
			if (null == anim)
				Object.Destroy(gameObject);
			else
				anim.Play("idle0");
		}
	}
	
}
