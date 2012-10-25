using UnityEngine;
using System.Collections;

public class ConstantRotation : MonoBehaviour {
	
	public Vector3 m_RotateAxis;
	public float m_RotationSpeed;

	// Update is called once per frame
	void Update () {
		transform.RotateAroundLocal(m_RotateAxis, Time.deltaTime * m_RotationSpeed);
	}
}
