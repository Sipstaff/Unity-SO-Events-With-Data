using UnityEngine;

[CreateAssetMenu(menuName = "GameEvent/Int Array GameEvent", order = 4)]
public class IntArrayGameEvent : GameEvent
{
    public void Raise(int[] intArray)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised(intArray);
        }
    }
    public int[] debugFloatArray;
}
