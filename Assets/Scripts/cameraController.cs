using UnityEngine;
using System.Collections;

public class cameraController : MonoBehaviour {
	
	public GameObject m_Helicopter = null;

	// Use this for initialization
	void Start () {
		if (null == m_Helicopter)
			throw new UnityException("Helicopter was not set");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = m_Helicopter.transform.position;
		
		transform.position = new Vector3(pos.x, pos.y, transform.position.z);
	}
}
