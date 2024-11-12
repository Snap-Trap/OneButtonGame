using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    public InputAction pressHit;

    private SpriteRenderer spriteRenderer;
    public Sprite defaultImage;
    public Sprite pressedImage;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (pressHit.triggered)
        {
            spriteRenderer.sprite = pressedImage;
        }
        else
        {
            spriteRenderer.sprite = defaultImage;
        }
    }

    private void OnEnable()
    {
        pressHit.Enable();
    }

    private void OnDisable()
    {
        pressHit.Disable();
    }
}
