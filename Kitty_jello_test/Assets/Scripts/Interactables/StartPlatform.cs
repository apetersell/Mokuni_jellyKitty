﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPlatform : Interactable {

    // Use this for initialization
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update () {
		
	}

    public override void Function()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            InteractableManager._interactables.Remove(this);
            Destroy(this.gameObject);
        }
    }
}
