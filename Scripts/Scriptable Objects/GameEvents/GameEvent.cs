using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class DataEvent : UnityEvent<EventData> { }

[System.Serializable]
public class GameObjectEvent : UnityEvent<GameObject> { }

[System.Serializable]
public class FloatEvent : UnityEvent<float> { }

[System.Serializable]
public class IntEvent : UnityEvent<int> { }

[System.Serializable]
public class FloatArrayEvent : UnityEvent<float[]> { }

[System.Serializable]
public class IntArrayEvent : UnityEvent<int[]> { }

public class GameEvent : ScriptableObject
{
    protected List<GameEventListener> listeners = new List<GameEventListener>();
    public void RegisterListener(GameEventListener listener)
    {
        if (!listeners.Contains(listener))
        {
            listeners.Add(listener);
        }
    }
    public void UnregisterListener(GameEventListener listener)
    {
        if (listeners.Contains(listener))
        {
            listeners.Remove(listener);
        }
    }
    protected void OnDisable()
    {
        listeners.Clear();
    }
    public void DebugMessage()
    {
        if (listeners.Count == 1)
        {
            Debug.Log("Event '" + name + "' called with 1 receiver.");
        }
        else
        {
            Debug.Log("Event '" + name + "' called with " + listeners.Count + " receivers.");
        }
    }
}
