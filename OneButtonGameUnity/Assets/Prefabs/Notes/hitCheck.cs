using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class hitCheck : MonoBehaviour
{
    public InputAction hit;

    private bool noteIsHit;

    [SerializeField] private bool canBeHit;

    // [SerializeField] private LayerMask buttonLayer;

    private void Update()
    {
        if (canBeHit)
        {
            if (hit.triggered)
            {
                noteIsHit = true;
                Destroy(gameObject);
                GameManager.instance.NoteHit();
            }
        }

        //if (canBeHit)
        //{
        //    if (!hit.triggered)
        //    {
        //        noteIsHit = false;
        //        GameManager.instance.NoteMiss();
        //    }
        //}
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Button")
        {
            Debug.Log("Note can be hit");
            canBeHit = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Button")
        {
            Debug.Log("The note can no longer be hit");
            canBeHit = false;

            if (!noteIsHit)
            {
                GameManager.instance.NoteMiss();
            }
        }
    }

    private void OnEnable()
    {
        hit.Enable();
    }

    private void OnDisable()
    {
        hit.Disable();
    }
}

