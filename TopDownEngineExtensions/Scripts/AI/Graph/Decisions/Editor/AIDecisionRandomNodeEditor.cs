using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionRandomNode))]
    public class AIDecisionRandomNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _totalChance;
        private SerializedProperty _odds;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            _totalChance = serializedObject.FindProperty("totalChance");
            _odds = serializedObject.FindProperty("odds");

            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_totalChance);
            NodeEditorGUILayout.PropertyField(_odds);
            serializedObject.ApplyModifiedProperties();
        }
    }
}