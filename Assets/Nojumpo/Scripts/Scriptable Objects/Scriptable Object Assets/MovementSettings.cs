using UnityEngine;

namespace Nojumpo.ScriptableObjects
{
    [CreateAssetMenu(fileName = "NewPlayerMovementSettings", menuName = "Nojumpo/Scriptable Objects/Player/New Player Movement Settings")]
    public class MovementSettings : ScriptableObject
    {
        #region Fields

#if UNITY_EDITOR

        [TextArea]
        [SerializeField] private string _developerDescription;

#endif

        [SerializeField] private float _movementSpeed = 15.0f;
        public float MovementSpeed { get { return _movementSpeed; } private set { _movementSpeed = value; } }

        [SerializeField] private float _jumpVelocity = 10.0f;
        public float JumpVelocity { get { return _jumpVelocity; } private set { _jumpVelocity = value; } }

        [SerializeField] private float _climbingSpeedOffset = 0.5f;
        public float ClimbingSpeedOffset { get { return _climbingSpeedOffset; } private set { _climbingSpeedOffset = value; } }

        [SerializeField] private CollisionCheckSettings _collisionCheckSettings;
        public CollisionCheckSettings CollCheckSettings { get { return _collisionCheckSettings; } }

        #endregion
    }
}