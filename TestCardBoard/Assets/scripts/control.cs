﻿using UnityEngine;
using System.Collections;

public class control : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position += new Vector3(0,0,3*Time.deltaTime);
	}
}
