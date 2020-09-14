using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionMMFeedbacksNode))]
    public class AIActionMMFeedbacksNodeEditor : AIActionNodeEditor
    {
        // private SerializedProperty _targetFeedbacks;
        private SerializedProperty _onlyPlayWhenEnteringState;

        protected override void SerializeAdditionalProperties()
        {
         //   _targetFeedbacks = serializedObject.FindProperty("targetFeedbacks");
            _onlyPlayWhenEnteringState = serializedObject.FindProperty("onlyPlayWhenEnteringState");

            serializedObject.Update();
         //   EditorGUIUtility.labelWidth = 110;
         //   NodeEditorGUILayout.PropertyField(_targetFeedbacks);
            EditorGUIUtility.labelWidth = 175;
            NodeEditorGUILayout.PropertyField(_onlyPlayWhenEnteringState);
            serializedObject.ApplyModifiedProperties();
            EditorGUILayout.Space();
            EditorGUILayout.HelpBox(
                "Target Feedbacks property is hidden in this node. You will have to manually add it once the generator has been executed (this means you cannot use it with the AIBrainPluggable).",
                MessageType.Warning);
        }
    }
}