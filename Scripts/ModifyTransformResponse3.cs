using System.Collections;
using UnityEngine;

namespace EnhancedTriggerbox.Component
{
    //Script ONLY used for probe station object respawn location 
    public class ModifyTransformResponse3 : ResponseComponent
    {
        private GameObject targetRespawn;
        /// <summary>
        /// This is how you will provide the response access to a specific gameobject. You can either use a reference, name or use the gameobject that collides with this trigger box.
        /// </summary>
        public ReferenceType referenceType;

        public override bool requiresCollisionObjectData 
        {
            get
            {
                return true;
            }
        }

        public enum ReferenceType
        {
            CollisionTransform,
        }

#if UNITY_EDITOR
        public override void DrawInspectorGUI()
        {
            referenceType = (ReferenceType)UnityEditor.EditorGUILayout.EnumPopup(new GUIContent("Reference Type",
                   "This is how you will provide the response access to a specific transform. You can either use a reference, name or use the gameobject that collides with this trigger box."), referenceType);

            duration = UnityEditor.EditorGUILayout.FloatField(new GUIContent("Change Duration",
                    "The duration that the selected change will happen over in seconds. If you leave it as 0 it will perform the changes instantly."), duration);
        }
#endif

        //Respawns the collided object to the respawn location
        public override bool ExecuteAction(GameObject collisionGameObject)
        {
            targetRespawn = GameObject.Find("RespawnPointTank");
            switch (referenceType)
            {
                case ReferenceType.CollisionTransform:
                    collisionGameObject.transform.position = targetRespawn.transform.position;
                    break;
            }
            return false;
        }
    }
}