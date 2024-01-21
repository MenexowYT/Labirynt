using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Transform playerCam;
	public Transform player;
	public float MouseX;
	public float MouseY;
	public float sens;

	void Update()
	{
		MouseX += Input.GetAxis("Mouse X") * Time.deltaTime;
		MouseY += Input.GetAxis("Mouse Y") * Time.deltaTime;

		player.rotation = Quaternion.Euler(0, MouseX * sens, 0);
		//playerCam.rotation = Quaternion.Euler(MouseY * sens, MouseX * sens, 0);
	}
}
