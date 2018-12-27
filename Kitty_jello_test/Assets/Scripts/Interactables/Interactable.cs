using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Interactable : MonoBehaviour {

    public float value;

	// Use this for initialization
    public virtual void Start () 
    {
        InteractableManager._interactables.Add(this);
    }

    public abstract void Function();
}