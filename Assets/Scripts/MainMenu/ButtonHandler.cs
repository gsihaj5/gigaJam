using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MainMenu
{
    public class ButtonHandler : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
    {
        [SerializeField] private Sprite idle;
        [SerializeField] private Sprite hover;
        [SerializeField] private Sprite clicked;

        private Image _image;

        private void Start()
        {
            _image = GetComponent<Image>();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            _image.sprite = hover;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            _image.sprite = clicked;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _image.sprite = idle;
        }
    }
}