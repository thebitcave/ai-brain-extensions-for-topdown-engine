using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionFaceTowardsTarget2DNode))]
    public class AIActionFaceTowardsTarget2DNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _mode;

        protected override void SerializeAdditionalProperties()
        {
            _mode = serializedObject.FindProperty("mode");

            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_mode);
            serializedObject.ApplyModifiedProperties();
        }

    }
}