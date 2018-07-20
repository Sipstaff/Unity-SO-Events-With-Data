using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(IntGameEvent))]
public class IntGameEventEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        EditorGUILayout.HelpBox("This Game-Event passes along a single integer value", MessageType.Info, true);
        IntGameEvent e = (IntGameEvent)target;

        GUI.enabled = Application.isPlaying;     
        e.debugValue = EditorGUILayout.IntField("Debug Value", e.debugValue);
        if (GUILayout.Button("Raise Event"))
        {
            e.Raise(e.debugValue);
            e.DebugMessage();
        }

    }
}
