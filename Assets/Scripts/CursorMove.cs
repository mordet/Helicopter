using UnityEngine;
using System.Collections;

public class CursorMove : MonoBehaviour {
	
	public GameObject m_Target = null;
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		Vector3 mPos = new Vector3(ray.origin.x, ray.origin.y, 0);

		m_Target.transform.position = mPos;
	}
}
