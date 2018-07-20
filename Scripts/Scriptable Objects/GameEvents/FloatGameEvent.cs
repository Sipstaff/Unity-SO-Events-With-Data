using UnityEngine;

[CreateAssetMenu(menuName = "GameEvent/Float GameEvent", order = 1)]
public class FloatGameEvent : GameEvent
{
    public void Raise(float value)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised(value);
        }
    }
    public float debugValue;
}
