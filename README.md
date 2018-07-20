# Unity-SO-Events-With-Data
Event System for Unity using ScriptableObjects (SO) based on the Unite 2017 talk by Ryan Hipple (Game Architecture with Scriptable Objects)

This package includes different types of GameEvents that allow to pass data along with the event to all listeners of that event.

* Basic GameEvent: The same type as the original, sending no data. Required reaction method structure: public void MethodName();
* Float GameEvent: A single float value is passed through. Required reaction method structure: public void MethodName(float value);
* Int GameEvent: A single integer value is passed through. Required reaction method structure: public void MethodName(int value);
* Float Array GameEvent: An array of floats is passed through. Required reaction method structure: public void MethodName(float[] values);
* Int Array GameEvent: An array of integers is passed through. Required reaction method structure: public void MethodName(int[] values);
* GameObject GameEvent: This passes a reference to GameObject through. Use with care, as listeners can manipulate the referenced GameObject. Required reaction method structure: public void MethodName(GameObject obj);
* Data GameEvent: This passes the customizable EventData struct through. Using this, it's possible to pass a delegate to the listener(s). Required reaction method structure: public void MethodName(EventData eventData);

## Usage
* Create the events through the asset menu and name them accordingly.
* The script raising the event needs a public field for the respective event type
* Any GameObject that needs to react to the event needs the GameEventListener script attached. Drop the event it needs to listen to in the field and assign a script with an appropriate public method.

## Notes
The GameEvents have public variables that can be used for debug purposes. The events can be raised with any value entered in the inspector during runtime.