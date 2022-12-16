using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventBus : MonoBehaviour
{
    private static EventBus _current;
    public static EventBus Current { get { return _current; } }
    private void Awake()
    {
        if (_current != null && _current != this)
        {
            Destroy(this.gameObject);
        } else {
            _current = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public event Action Cube;
    public void CubeTrigger()
    {
        Cube();
    }

    public event Action Switch;

    public void Switchtrigger()
    {
        Switch();
    }

}
