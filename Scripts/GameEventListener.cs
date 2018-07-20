using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    public GameEvent gameEvent;
    public UnityEvent basicResponse;
    public FloatEvent floatResponse;
    public IntEvent intResponse;
    public FloatArrayEvent floatArrayResponse;
    public IntArrayEvent intArrayResponse;
    public GameObjectEvent gameObjectResponse;
    public DataEvent dataResponse;

    private void OnEnable()
    {
        gameEvent.RegisterListener(this);
    }
    private void OnDisable()
    {
        gameEvent.UnregisterListener(this);
    }

    public void OnEventRaised()
    {
        basicResponse.Invoke();
    }
    public void OnEventRaised(float floatValue)
    {
        floatResponse.Invoke(floatValue);
    }
    public void OnEventRaised(int intValue)
    {
        intResponse.Invoke(intValue);
    }
    public void OnEventRaised(float[] floatArray)
    {
        floatArrayResponse.Invoke(floatArray);
    }
    public void OnEventRaised(int[] intArray)
    {
        intArrayResponse.Invoke(intArray);
    }
    public void OnEventRaised(GameObject obj)
    {
        gameObjectResponse.Invoke(obj);
    }
    public void OnEventRaised(EventData eventData)
    {
        dataResponse.Invoke(eventData);
    }
}
