using UnityEngine;
using System.Collections;

public class GunRotation : MonoBehaviour {
	public GameObject m_Target = null;
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(m_Target.transform);
	}
}
