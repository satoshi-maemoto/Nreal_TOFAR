using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace NrealTofAr
{
    public class NRColorfulDropdown : colorfulDropdown
    {
        public override void OnPointerClick(PointerEventData eventData)
        {
            base.OnPointerClick(eventData);
            RemoveUnityCanvas();
        }

        private void RemoveUnityCanvas()
        {
            var raycasttarget = gameObject.GetComponentsInChildren<GraphicRaycaster>();
            foreach (var item in raycasttarget)
            {
                GameObject.Destroy(item);
            }

            var canvas = gameObject.GetComponentsInChildren<Canvas>();
            foreach (var item in canvas)
            {
                GameObject.Destroy(item);
            }
        }
    }
}