﻿using UnityEngine;
using System.Collections;

public class PlayParticle : MonoBehaviour
{
	private float lastTime;
	private ParticleSystem ps;
	public int pauso = 1;
	
	private void Awake ()
	{
		ps = GetComponent<ParticleSystem> ();
	}
	
	void Start ()
	{
		/*lastTime = Time.realtimeSinceStartup;
		if(pauso == 0)
		{
			float deltaTime = Time.realtimeSinceStartup - lastTime;
			ps.Simulate (deltaTime, true, false);
			lastTime = Time.realtimeSinceStartup;
		}
		pauso = 1;*/
	}
	
	void Update ()
	{
		if(pauso == 0)
		{
			float deltaTime = Time.realtimeSinceStartup - lastTime;
			ps.Simulate (deltaTime, true, false);
			lastTime = Time.realtimeSinceStartup;
		}
	}

	public void Pause()
	{
		pauso += 1;
	}
	public void Resume()
	{
		pauso -= 1;
	}
}
