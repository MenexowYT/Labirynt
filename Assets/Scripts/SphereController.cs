using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
	public Transform player;
	public float speed;
	public float x;
	public float z;

	void Update()
	{
		x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		z = Input.GetAxis("Vertical") * speed * Time.deltaTime;

		Vector3 move = transform.right * x + transform.forward * z;
		//player.Translate(x * speed * Time.deltaTime, 0, z * speed * Time.deltaTime);
		GetComponent<Rigidbody>().velocity = move;
	}
}
