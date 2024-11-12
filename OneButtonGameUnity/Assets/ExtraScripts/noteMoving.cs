using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class noteMoving : MonoBehaviour
{
    public float bpm = 120f;

    public bool gameStart;

    public GameObject[] notes;

    private void Update()
    {
        if (gameStart)
        {
            for (int i = 0; i < notes.Length; i++)
            {
                notes[i].transform.position -= new Vector3(0, 0.1f * bpm * Time.deltaTime, 0);
            }
        }
    }
}
