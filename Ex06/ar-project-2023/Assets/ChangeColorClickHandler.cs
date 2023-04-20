using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeColorClickHandler : MonoBehaviour, IPointerClickHandler
{
    private Renderer _renderer;
    
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        _renderer.material.color =
            _renderer.material.color == Color.yellow ? Color.green : Color.yellow;
    }
}
