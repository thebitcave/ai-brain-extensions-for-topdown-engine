using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionRotateTowardsTarget2DNode))]
    public class AIActionRotateTowardsTarget2DNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _lockRotationX;

        protected override void SerializeAdditionalProperties()
        {
            _lockRotationX = serializedObject.FindProperty("lockRotationX");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 200;
            NodeEditorGUILayout.PropertyField(_lockRotationX);
            serializedObject.ApplyModifiedProperties();
        }
    }
}