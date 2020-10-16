using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TriggerButton : MonoBehaviour
{   
    public GameObject triggerButton;
    public Animator humanoidAnimator;
    public AudioSource humanoidAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        triggerButton = GameObject.Find("TriggerButton");
        triggerButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        triggerButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        humanoidAnimator.GetComponent<Animator>();
        humanoidAudioSource.GetComponent<AudioSource>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        humanoidAnimator.SetTrigger("TriggerGoal");
        humanoidAudioSource.Play();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
