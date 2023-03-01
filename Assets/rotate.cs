using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
	public float speed = 10f;
	public Transform CubeTransform;

	void Update()
	{
		transform.RotateAround(CubeTransform.position, Vector3.up, speed * Time.deltaTime);
	}

	void OnMouseDown()
	{
		if (GetComponent<Renderer>().material.color == Color.red)
			GetComponent<Renderer>().material.color = Color.green;
		else
			GetComponent<Renderer>().material.color = Color.red;
		speed = speed + 5f;
	}
}