using UnityEngine;
using System.Collections;

public class SpinningCube : MonoBehaviour 
{
	public float m_Speed = 60f; // speed rotation of the cube
	private Vector3 RotationDirection = Vector3.up; // vector init


	public void ToggleRotationDirection()
	{
		if (RotationDirection == Vector3.up) 
		{
			RotationDirection = Vector3.down;
		}
		else 
		{
			RotationDirection = Vector3.up;
		}

	}

	void Update() 
	{
		transform.Rotate(RotationDirection * Time.deltaTime * m_Speed);
	}
}
