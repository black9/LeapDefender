using UnityEngine;
using System.Collections;
using System;

public class PlayerScript : MonoBehaviour
{
	/// <summary>
	/// Crosshairs
	/// </summary>
	public Transform Crosshair1, CrossHair2;
	
	void Start ()
	{
		// Hide mouse :3
		Screen.showCursor = false;
	}
	
	void Update ()
	{
		if (Crosshair1 != null) {
			
			RaycastHit hit;
			Ray ray = Camera.mainCamera.ScreenPointToRay (Input.mousePosition);
			
			if (Physics.Raycast (ray, out hit) && hit.transform.name == "Ground") {
				Crosshair1.localPosition = new Vector3(hit.point.x, 2 , hit.point.z);
			}
			
				
			
		}
	}
}