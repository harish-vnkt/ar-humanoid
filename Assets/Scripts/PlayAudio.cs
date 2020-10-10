using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame

    void OnBecameVisible() {
        audioSource.mute = false;
        audioSource.Play();
    }

    void OnBecameInvisible() {
        audioSource.mute = true;
    }
    void Update()
    {
        
    }
}
