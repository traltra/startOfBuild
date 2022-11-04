using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    private SpriteRenderer _sprite;
    private Character _player;
    public UnityEvent _events;
    // Start is called before the first frame update
    void Start()
    {
        _sprite = GetComponentInParent<SpriteRenderer>();
        _sprite.enabled = false;
        _player = FindObjectOfType<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        _sprite.enabled = _sprite.bounds.Intersects(_player._characterSprite.bounds);
        if(_sprite.enabled && Input.GetKeyDown(KeyCode.E))
        {
            _events.Invoke();
        }
    }
}
