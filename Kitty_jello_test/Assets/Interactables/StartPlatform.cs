﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlatform : Interactable {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void Function()
    {
        throw new System.NotImplementedException();
    }

    public override void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}
