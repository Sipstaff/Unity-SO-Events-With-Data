using UnityEngine;

[CreateAssetMenu(menuName = "GameEvent/GameObject GameEvent", order = 5)]
public class GameObjectGameEvent : GameEvent
{
    public void Raise(GameObject obj)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised(obj);
        }
    }
    public GameObject debugGameObject;
}
