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
        private SerializedProperty _lockVerticalAim;

        protected override void SerializeAdditionalProperties()
        {
            _aimAtTarget = serializedObject.FindProperty("aimAtTarget");
            _shootOffset = serializedObject.FindProperty("shootOffset");
            _lockVerticalAim = serializedObject.FindProperty("lockVerticalAim");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 105;
            NodeEditorGUILayout.PropertyField(_aimAtTarget);
            NodeEditorGUILayout.PropertyField(_shootOffset);
            NodeEditorGUILayout.PropertyField(_lockVerticalAim);
            serializedObject.ApplyModifiedProperties();
        }
    }
}