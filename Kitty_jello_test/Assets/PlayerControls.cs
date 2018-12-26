using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

    public static Interactable selected;
    public Interactable visSelect;

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        visSelect = selected;
        if (selected != null)
        {
            selected.Function();
        }
        SelectObject();
	}

    void SelectObject()
    {
        if (Input.GetMouseButtonUp(0))
        {
            selected = null;
        }
    }
}
