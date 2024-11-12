using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class noteMoving : MonoBehaviour
{
    public InputAction startHit;

    public float bpm = 120f;

    public bool gameStart;

    public GameObject[] notes;

    private void Start()
    {
        bpm = bpm / 60f;
    }

    private void Update()
    {
        // Doing two checks so you can't start the game more than once
        if (!gameStart)
        {
            if (startHit.triggered)
            {
                Debug.Log("Game Start!");
                gameStart = true;
            }
        }

        // Makes the notes move downwards
        if (gameStart)
        {
            transform.position -= new Vector3(0, bpm * Time.deltaTime, 0);
        }
    }

    private void OnEnable()
    {
        startHit.Enable();
    }

    private void OnDisable()
    {
        startHit.Disable();
    }
}
