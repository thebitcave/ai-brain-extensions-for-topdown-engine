using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionSwapBrainNode))]
    public class AIActionSwapBrainNodeEditor : AIActionNodeEditor
    {
        // private SerializedProperty _newAIBrain;

        protected override void SerializeAdditionalProperties()
        {
            // _newAIBrain = serializedObject.FindProperty("newAIBrain");

            serializedObject.Update();
            // NodeEditorGUILayout.PropertyField(_newAIBrain);
            serializedObject.ApplyModifiedProperties();
            EditorGUILayout.Space();
            EditorGUILayout.HelpBox(
                "New AI Brain property is hidden. You will have to manually add it once the generator has been executed or assign it at runtime.",
                MessageType.Warning);
        }

    }
}