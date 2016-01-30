﻿using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

	void Start()
	{
		//Causes UI object not to be destroyed when loading a new scene. If you want it to be destroyed, destroy it manually via script.
        if (GetComponent<StartOptions>().sceneToStart == 0)
		    DontDestroyOnLoad(this.gameObject);
	}

	

}