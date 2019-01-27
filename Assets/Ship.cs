using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Ship : NetworkBehaviour
{
    void Start()
    {
        
    }
	
    void Update()
    {
		if (isServer)
		{
			transform.position += new Vector3(0, -Time.deltaTime * 5f, -Time.deltaTime * 3f);
			transform.eulerAngles += new Vector3(Time.deltaTime * 30f, 0, 0);
		}
    }
}
