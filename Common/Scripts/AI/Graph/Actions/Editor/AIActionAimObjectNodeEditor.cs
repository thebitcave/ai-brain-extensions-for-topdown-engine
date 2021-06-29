using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using UnityEngine;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionAimObjectNode))]
    public class AIActionAimObjectNodeEditor : AIActionNodeEditor
    {
        // private SerializedProperty _gameObjectToAim;
        private SerializedProperty _mode;
        private SerializedProperty _axis;
        private SerializedProperty _interpolate;
        private SerializedProperty _interpolateRate;

        protected override void SerializeAdditionalProperties()
        {
            // _gameObjectToAim = serializedObject.FindProperty("gameObjectToAim");
            _mode = serializedObject.FindProperty("mode");
            _axis = serializedObject.FindProperty("axis");
            _interpolate = serializedObject.FindProperty("interpolate");
            _interpolateRate = serializedObject.FindProperty("interpolateRate");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 100;
            // NodeEditorGUILayout.PropertyField(_gameObjectToAim);
            NodeEditorGUILayout.PropertyField(_mode);
            NodeEditorGUILayout.PropertyField(_axis);
            NodeEditorGUILayout.PropertyField(_interpolate);
            if (_interpolate.boolValue)
            {
                NodeEditorGUILayout.PropertyField(_interpolateRate);
            }
            serializedObject.ApplyModifiedProperties();
            EditorGUILayout.Space();
            EditorGUILayout.HelpBox(
                "Game Object to Aim property is hidden. You will have to manually add it once the generator has been executed or assign it at runtime.",
                MessageType.Warning);
        }
    }
}