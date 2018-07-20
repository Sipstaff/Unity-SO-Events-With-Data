using UnityEngine;

[CreateAssetMenu(menuName = "GameEvent/Basic GameEvent", order = 0)]
public class BasicGameEvent : GameEvent
{
    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }
}
