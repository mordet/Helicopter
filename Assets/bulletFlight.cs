using UnityEngine;
using System.Collections;

public class bulletFlight : MonoBehaviour {
	
	public float m_BulletSpeed=50;
	
	private Rigidbody m_Rigid;
	
	// Use this for initialization
	void Start () {
		
		// transform.position.z;
		Destroy(gameObject, 2);
		
		m_Rigid = GetComponent<Rigidbody>();
		if (null == m_Rigid)
			throw new UnityException("Rigidbody was not found");
		
		Vector3 forward = transform.right;
		forward.Set(-forward.x, -forward.y, forward.z);
		
		//forward.Scale (new Vector3());
		m_Rigid.AddForce (forward * m_BulletSpeed, ForceMode.Impulse);
		
	}
	
	void FixedUpdate ()
	{
	}
	
	void OnCollisionEnter(Collision collision) {
		destroybelObject dest = collision.gameObject.GetComponent<destroybelObject>();
		
		if(null != dest)
		{
			dest.reduceHealth(1);
		}
		
		Object.Destroy(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
