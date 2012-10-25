using UnityEngine;
using System.Collections;

public class HelicopterHealth : MonoBehaviour {
	
	public float m_Health = 100;

	private void ReduceHealth(float amount)	{
		m_Health -= amount;
		if (m_Health <= 0)
		{
			Death();
		}
	}
	
	private void Death()
	{
		Application.LoadLevel("GameOver");
	}
	
	void OnCollisionEnter(Collision collision)
	{
		Environment env = collision.gameObject.GetComponent<Environment>();
		if (null != env)
		{
			ReduceHealth(collision.relativeVelocity.magnitude / 10);
		}
		
		Victory vic = collision.gameObject.GetComponent<Victory>();
		if (null != vic)
		{
			Application.LoadLevel("Victory");
		}
	}
	
	void OnGUI()
	{
		GUILayout.BeginArea(new Rect(30, 30, 400, 200));
		
		if (m_Health > 0)
			GUILayout.Label("Health: " + m_Health);
		else
			GUILayout.Label("DEAD!!!");
		GUILayout.EndArea();
	}
}
