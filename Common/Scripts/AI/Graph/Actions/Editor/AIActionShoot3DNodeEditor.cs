using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIActionShoot3DNode))]
    public class AIActionShoot3DNodeEditor : AIActionNodeEditor
    {
//        private SerializedProperty _targetHandleWeaponAbility;
        private SerializedProperty _aimAtTarget;
        private SerializedProperty _shootOffset;
        private SerializedProperty _lockVerticalAim;

        protected override void SerializeAdditionalProperties()
        {
            //          _targetHandleWeaponAbility = serializedObject.FindProperty("targetHandleWeaponAbility");
            _aimAtTarget = serializedObject.FindProperty("aimAtTarget");
            _shootOffset = serializedObject.FindProperty("shootOffset");
            _lockVerticalAim = serializedObject.FindProperty("lockVerticalAim");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 85;
            //          NodeEditorGUILayout.PropertyField(_targetHandleWeaponAbility);
            NodeEditorGUILayout.PropertyField(_aimAtTarget);
            NodeEditorGUILayout.PropertyField(_shootOffset);
            EditorGUIUtility.labelWidth = 110;
            NodeEditorGUILayout.PropertyField(_lockVerticalAim);
            
            EditorGUILayout.HelpBox(
                "Target Handle Weapon Ability property is hidden. You will have to manually add it once the generator has been executed or assign it at runtime.",
                MessageType.Warning);

            serializedObject.ApplyModifiedProperties();
        }
    }
}