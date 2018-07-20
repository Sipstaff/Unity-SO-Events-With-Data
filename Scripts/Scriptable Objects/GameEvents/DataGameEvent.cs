using UnityEngine;

[CreateAssetMenu(menuName = "GameEvent/Data GameEvent", order = 6)]
public class DataGameEvent : GameEvent
{
    public void Raise(EventData data)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised(data);
        }
    }
    public EventData debugEventData;
}
