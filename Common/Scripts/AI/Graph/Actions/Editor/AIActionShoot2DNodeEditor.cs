using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionShoot2DNode))]
    public class AIActionShoot2DNodeEditor : AIActionNodeEditor
    {
//        private SerializedProperty _targetHandleWeaponAbility;
        private SerializedProperty _aimOrigin;
        private SerializedProperty _faceTarget;
        private SerializedProperty _aimAtTarget;

        protected override void SerializeAdditionalProperties()
        {
  //          _targetHandleWeaponAbility = serializedObject.FindProperty("targetHandleWeaponAbility");
            _aimOrigin = serializedObject.FindProperty("aimOrigin");
            _faceTarget = serializedObject.FindProperty("faceTarget");
            _aimAtTarget = serializedObject.FindProperty("aimAtTarget");

            serializedObject.Update();
  //          NodeEditorGUILayout.PropertyField(_targetHandleWeaponAbility);
            NodeEditorGUILayout.PropertyField(_aimOrigin);
            NodeEditorGUILayout.PropertyField(_faceTarget);
            NodeEditorGUILayout.PropertyField(_aimAtTarget);
            
            EditorGUILayout.HelpBox(
                "Target Handle Weapon Ability property is hidden. You will have to manually add it once the generator has been executed or assign it at runtime.",
                MessageType.Warning);

            serializedObject.ApplyModifiedProperties();
        }
    }
}