using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent StartEvent, EnableEvent, MouseDownEvent, UpdateEvent, TriggerEnterEvent;

	private void Start ()
    {
        StartEvent.Invoke();
	}

    private void OnEnable()
    {
        EnableEvent.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        TriggerEnterEvent.Invoke();
    }


	private void Update ()
    {
        UpdateEvent.Invoke();
	}
}
