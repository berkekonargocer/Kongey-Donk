using DG.Tweening;
using Nojumpo.Interfaces;
using UnityEngine;
using Nojumpo.ScriptableObjects;
using Nojumpo.Managers;

namespace Nojumpo
{
    public class Collectable : MonoBehaviour, ICollectable
    {
        #region Fields

        [SerializeField] private ItemType _itemType;
        public ItemType ItemType { get { return _itemType; } }

        #region Animation Settings
        [Header("Animation Settings")]

        [SerializeField] private GameObject _uiPositionObject;
        [SerializeField] private float _animationTime = 2.5f;

        #endregion

        #region Sound Effects Settings
        [Header("Sound Effects Settings")]

        [SerializeField] private AudioSource _collectAudioSource;
        [SerializeField] private AudioClip _collectSFXAudio;

        #endregion

        #endregion



        #region Custom Private Methods

        private void PlayCollectAnimation() {
            transform.parent = _uiPositionObject.transform;
            gameObject.transform.DOLocalMove(Vector3.zero, _animationTime).SetUpdate(true);
        }

        #endregion

        #region Custom Public Methods

        public void Collect() {
            CollectedItems.ItemsCollection.Add(_itemType);
            AudioManager.Instance.PlayAudio(_collectAudioSource, _collectSFXAudio);
            PlayCollectAnimation();
        }

        #endregion
    }
}