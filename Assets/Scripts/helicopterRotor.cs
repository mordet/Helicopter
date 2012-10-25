using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class helicopterRotor : MonoBehaviour {
	private Rigidbody m_Rigid = null;
	public float m_SensitivityForce = 1;
	public float m_SensitivityRotate = 1;
	
	// Use this for initialization
	void Start () {
		m_Rigid = GetComponent<Rigidbody>();
		if (null == m_Rigid)
			throw new UnityException("Rigidbody was not found");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		m_Rigid.angularVelocity = Vector3.zero;
		
		m_Rigid.AddRelativeTorque(0, 0, 
			-1 * Input.GetAxis("Horizontal") * m_Rigid.mass * m_SensitivityRotate,
			ForceMode.Impulse);
		
		float userForce = Input.GetAxis("Vertical") * m_Rigid.mass * m_SensitivityForce;
		Vector3 up = transform.up;
		up.Scale(new Vector3(userForce, userForce, userForce));
		m_Rigid.AddRelativeForce(up);
	}	
}
