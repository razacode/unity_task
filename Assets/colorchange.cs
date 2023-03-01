using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour
{
	public float speed = 10f;
	public Transform sphereTransform;
	public GameObject sphere;



	// Start is called before the first frame update
	void Start()
    {
		GetComponent<Renderer>().material.color = Color.red;

	}

    // Update is called once per frame
    void Update()
    {
		sphereTransform.RotateAround(transform.position, Vector3.up, speed * Time.deltaTime);

	}

	void OnMouseDown()
	{
		if (GetComponent<Renderer>().material.color == Color.red)
		{
			GetComponent<Renderer>().material.color = Color.green;
			sphere.GetComponent<Renderer>().material.color = Color.green;

		}

		else
		{
			GetComponent<Renderer>().material.color = Color.red;
			sphere.GetComponent<Renderer>().material.color = Color.red;
		}

		speedup();

	}

	void speedup()
	{
		speed = speed + 5f;

	}
}
