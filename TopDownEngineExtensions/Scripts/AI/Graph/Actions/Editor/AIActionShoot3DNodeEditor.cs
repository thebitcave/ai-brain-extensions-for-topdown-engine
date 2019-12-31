using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionShoot3DNode))]
    public class AIActionShoot3DNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _aimAtTarget;
        private SerializedProperty _shootOffset;

        protected override void SerializeAdditionalProperties()
        {
            _aimAtTarget = serializedObject.FindProperty("aimAtTarget");
            _shootOffset = serializedObject.FindProperty("shootOffset");

            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_aimAtTarget);
            NodeEditorGUILayout.PropertyField(_shootOffset);
            serializedObject.ApplyModifiedProperties();
        }
    }
}