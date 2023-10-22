using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScroll : MonoBehaviour
{
    [SerializeField] private RawImage _img;
    [SerializeField] private RawImage _text;
    [SerializeField] private float _x, _y;
    [SerializeField] private Button _buttonToAppearz;
    public Vector2 newPosition; 

    void Start() {
        _buttonToAppearz.interactable = false;
    }
    // Update is called once per frame
    void Update()
    {
            _img.uvRect = new Rect(_img.uvRect.position + new Vector2(_x, _y) * Time.deltaTime, _img.uvRect.size);
            
            // Check if scrolling is complete (e.g., when the desired position is reached)
            if (_img.uvRect.y <= -0.85f)
            {
                _buttonToAppearz.interactable = true;
                RectTransform buttonRectTransform = _buttonToAppearz.GetComponent<RectTransform>();
                buttonRectTransform.anchoredPosition = newPosition;
                //RectTransform textRectTransform = _text.GetComponent<RectTransform>();
                //textRectTransform.anchoredPosition = newPosition;


            }
        }
}