using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ToolMaster : MonoBehaviour
{
    // Create unity events for function calls
    public UnityEvent<Ray> aimFunc;
    public UnityEvent<Ray> fireFunc;
    public UnityEvent instFunc;

    // Awake is called when the object is instantiated
    private void Awake()
    {
        instFunc.Invoke();
    }

    // Fire is called from parent object
    public void Fire(Ray forward)
    {
        fireFunc.Invoke(forward);
    }

    // Aim is called froom parent object
    public void Aim(Ray forward)
    {
        aimFunc.Invoke(forward);
    }
}