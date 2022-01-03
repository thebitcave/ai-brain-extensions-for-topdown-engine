using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionUnityEventsNode))]
    public class AIActionUnityEventsNodeEditor : AIActionNodeEditor
    {
//        private SerializedProperty _targetEvent;
        private SerializedProperty _onlyPlayWhenEnteringState;

        protected override void SerializeAdditionalProperties()
        {
//            _targetEvent = serializedObject.FindProperty("targetEvent");
            _onlyPlayWhenEnteringState = serializedObject.FindProperty("onlyPlayWhenEnteringState");

            serializedObject.Update();
//            NodeEditorGUILayout.PropertyField(_targetEvent);
            EditorGUIUtility.labelWidth = 200;
            NodeEditorGUILayout.PropertyField(_onlyPlayWhenEnteringState);
            serializedObject.ApplyModifiedProperties();
            EditorGUILayout.Space();
            EditorGUILayout.HelpBox(
                "Target Event property is hidden. You will have to manually add it once the generator has been executed or assign it at runtime.",
                MessageType.Warning);
        }
    }
}