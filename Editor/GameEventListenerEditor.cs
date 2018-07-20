using UnityEditor;

[CustomEditor(typeof(GameEventListener))]
public class GameEventListenerEditor : Editor {

    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        GameEventListener script = (GameEventListener)target;

        script.gameEvent = (GameEvent)EditorGUILayout.ObjectField("Game Event", script.gameEvent, typeof(GameEvent),false);

        SerializedProperty basicResponse = serializedObject.FindProperty("basicResponse");
        SerializedProperty dataResponse = serializedObject.FindProperty("dataResponse");
        SerializedProperty gameObjectResponse = serializedObject.FindProperty("gameObjectResponse");
        SerializedProperty floatResponse = serializedObject.FindProperty("floatResponse");
        SerializedProperty intResponse = serializedObject.FindProperty("intResponse");
        SerializedProperty floatArrayResponse = serializedObject.FindProperty("floatArrayResponse");
        SerializedProperty intArrayResponse = serializedObject.FindProperty("intArrayResponse");

        if (script.gameEvent != null)
        {
            if(script.gameEvent.GetType() == typeof(BasicGameEvent))
            {
                EditorGUILayout.PropertyField(basicResponse);
            }
            if(script.gameEvent.GetType() == typeof(DataGameEvent))
            {
                EditorGUILayout.PropertyField(dataResponse);
            }
            if (script.gameEvent.GetType() == typeof(GameObjectGameEvent))
            {
                EditorGUILayout.PropertyField(gameObjectResponse);
            }
            if (script.gameEvent.GetType() == typeof(FloatGameEvent))
            {
                EditorGUILayout.PropertyField(floatResponse);
            }
            if (script.gameEvent.GetType() == typeof(IntGameEvent))
            {
                EditorGUILayout.PropertyField(intResponse);
            }
            if (script.gameEvent.GetType() == typeof(FloatArrayGameEvent))
            {
                EditorGUILayout.PropertyField(floatArrayResponse);
            }
            if (script.gameEvent.GetType() == typeof(IntArrayGameEvent))
            {
                EditorGUILayout.PropertyField(intArrayResponse);
            }
        }
        serializedObject.ApplyModifiedProperties();

    }
}
