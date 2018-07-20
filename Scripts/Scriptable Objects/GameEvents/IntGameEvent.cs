using UnityEngine;

[CreateAssetMenu(menuName = "GameEvent/Int GameEvent", order = 2)]
public class IntGameEvent : GameEvent
{
    public void Raise(int value)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised(value);
        }
    }
    public int debugValue;
}
