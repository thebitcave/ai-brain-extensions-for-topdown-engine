using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using UnityEngine;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionReloadNode))]
    public class AIActionReloadNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _onlyReloadOnceInThisState;

        protected override void SerializeAdditionalProperties()
        {
            _onlyReloadOnceInThisState = serializedObject.FindProperty("onlyReloadOnceInThisState");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 100;
            NodeEditorGUILayout.PropertyField(_onlyReloadOnceInThisState);
            serializedObject.ApplyModifiedProperties();
        }
    }
}