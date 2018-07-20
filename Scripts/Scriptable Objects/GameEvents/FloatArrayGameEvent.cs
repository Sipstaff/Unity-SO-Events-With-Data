using UnityEngine;

[CreateAssetMenu(menuName = "GameEvent/Float Array GameEvent", order = 3)]
public class FloatArrayGameEvent : GameEvent
{
    public void Raise(float[] floatArray)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised(floatArray);
        }
    }
    public float[] debugFloatArray;
}
