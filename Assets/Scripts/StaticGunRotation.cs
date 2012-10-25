using UnityEngine;
using System.Collections;

public class StaticGunRotation : MonoBehaviour {
	public GameObject m_Target = null;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//transform.LookAt(m_Target.transform);
		//transform.localRotation.eulerAngles.x += 90;
		//transform.RotateAround(new Vector3(0, 0, 90), 90);
	}
}
