using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionMoveTowardsTarget3DNode))]
    public class AIActionMoveTowardsTarget3DNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _minimumDistance;
        
        protected override void SerializeAdditionalProperties()
        {
            _minimumDistance = serializedObject.FindProperty("minimumDistance");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 180;
            NodeEditorGUILayout.PropertyField(_minimumDistance);
            serializedObject.ApplyModifiedProperties();
        }
    }
}