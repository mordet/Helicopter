using UnityEngine;
using System.Collections;

public class fire : MonoBehaviour {
	
	public GameObject bullet;
	private float lastShotTime = 0;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetButton("Fire1"))
		{
			if (Time.time - lastShotTime > 0.05)
			{
				lastShotTime = Time.time;
				GameObject newBullet = (GameObject)Instantiate (bullet, transform.position, transform.rotation);
			}
			
			//newBullet.transform.Rotate(new Vector3(0, 90, 0));
		}
		
	}
}
