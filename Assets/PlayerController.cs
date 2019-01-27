using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerController : NetworkBehaviour
{
    void Start()
    {
		transform.parent = GameObject.Find("Players").transform;
		transform.localPosition = new Vector3(0, 1f, 0);
		transform.rotation = GameObject.Find("Players").transform.rotation;

		if (isLocalPlayer)
			Camera.main.GetComponent<CameraController>().target = transform.GetChild(3);
    }
	
    void Update()
    {
		if (isLocalPlayer)
			if (Input.GetKey(KeyCode.Space))
				transform.localPosition += new Vector3(Time.deltaTime * 3, 0, 0);
    }
}
