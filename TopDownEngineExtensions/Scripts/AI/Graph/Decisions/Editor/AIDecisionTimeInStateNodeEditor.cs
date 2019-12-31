using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionTimeInStateNode))]
    public class AIDecisionTimeInStateNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _afterTimeMin;
        private SerializedProperty _afterTimeMax;
        
        protected override void SerializeAdditionalProperties()
        {
            _afterTimeMin = serializedObject.FindProperty("afterTimeMin");
            _afterTimeMax = serializedObject.FindProperty("afterTimeMax");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 100;
            NodeEditorGUILayout.PropertyField(_afterTimeMin);
            NodeEditorGUILayout.PropertyField(_afterTimeMax);
            serializedObject.ApplyModifiedProperties();
        }

    }
}