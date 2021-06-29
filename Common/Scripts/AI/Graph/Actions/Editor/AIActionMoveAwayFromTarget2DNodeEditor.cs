using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using UnityEngine;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionMoveAwayFromTarget2DNode))]
    public class AIActionMoveAwayFromTarget2DNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _maximumDistance;

        protected override void SerializeAdditionalProperties()
        {
            _maximumDistance = serializedObject.FindProperty("maximumDistance");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 150;
            NodeEditorGUILayout.PropertyField(_maximumDistance);
            serializedObject.ApplyModifiedProperties();
        }
    }
}