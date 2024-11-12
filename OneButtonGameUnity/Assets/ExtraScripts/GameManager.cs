using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public noteMoving noteMoving;
    
    public AudioSource mainMusic;

    [SerializeField] private bool startPlaying = false;

    public static GameManager instance;

    private void Start()
    {
        instance = this;
    }

    private void Update()
    {
        if (!startPlaying)
            // Making sure it doesn't start from the get go
        {
            if (noteMoving.gameStart)
            {
                startPlaying = true;
                mainMusic.Play();
            }
        }
    }

    public void NoteHit()
    {
        Debug.Log("Note Hit on time");
    }

    public void NoteMiss()
    {
        Debug.Log("Note Missed");
    }
}
