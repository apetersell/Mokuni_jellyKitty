using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InteractableManager._interactables.Clear();
            SceneManager.LoadScene(0);
        }
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
