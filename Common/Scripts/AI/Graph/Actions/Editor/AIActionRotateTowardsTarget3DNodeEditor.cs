using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionRotateTowardsTarget3DNode))]
    public class AIActionRotateTowardsTarget3DNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _lockRotationX;

        protected override void SerializeAdditionalProperties()
        {
            _lockRotationX = serializedObject.FindProperty("lockRotationX");

            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_lockRotationX);
            serializedObject.ApplyModifiedProperties();
        }
    }
}