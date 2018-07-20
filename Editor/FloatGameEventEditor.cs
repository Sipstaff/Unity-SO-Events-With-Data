using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(FloatGameEvent))]
public class FloatGameEventEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        EditorGUILayout.HelpBox("This Game-Event passes along a single float value", MessageType.Info, true);
        FloatGameEvent e = (FloatGameEvent)target;

        GUI.enabled = Application.isPlaying;
        e.debugValue = EditorGUILayout.FloatField("Debug Value", e.debugValue);
        if (GUILayout.Button("Raise"))
        {
            e.Raise(e.debugValue);
            e.DebugMessage();
        }

    }
}
