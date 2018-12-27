using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableManager : MonoBehaviour {

    public static List<Interactable> _interactables = new List<Interactable>();
    public Slider slider;

    // Use this for initialization
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Interactable i in _interactables)
        {
            i.value = slider.value;
            i.Function();
        }
    }
}
