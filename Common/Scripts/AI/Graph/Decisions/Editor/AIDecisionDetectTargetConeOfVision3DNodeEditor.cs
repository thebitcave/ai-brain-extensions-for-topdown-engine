using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionDetectTargetConeOfVision3DNode))]
    public class AIDecisionDetectTargetConeOfVision3DNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _setTargetToNullIfNotFound;

        protected override void SerializeAdditionalProperties()
        {
            _setTargetToNullIfNotFound = serializedObject.FindProperty("setTargetToNullIfNotFound");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 190;
            NodeEditorGUILayout.PropertyField(_setTargetToNullIfNotFound);
            serializedObject.ApplyModifiedProperties();
        }

    }
}