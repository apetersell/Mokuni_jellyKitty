﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    public virtual void Function()
    {

    }

    public virtual void OnMouseDown()
    {
        PlayerControls.selected = this;
    }
}