using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionShoot2DNode))]
    public class AIActionShoot2DNodeEditor : AIActionNodeEditor
    {
        private SerializedProperty _faceTarget;
        private SerializedProperty _aimAtTarget;

        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            _faceTarget = serializedObject.FindProperty("faceTarget");
            _aimAtTarget = serializedObject.FindProperty("aimAtTarget");

            serializedObject.Update();
            NodeEditorGUILayout.PropertyField(_faceTarget);
            NodeEditorGUILayout.PropertyField(_aimAtTarget);
            serializedObject.ApplyModifiedProperties();
        }
    }
}