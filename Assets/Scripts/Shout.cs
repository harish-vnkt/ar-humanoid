using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shout : MonoBehaviour
{
    public Animator humanoidAnimator; 
    public GameObject mainPlayset;
    public float minimumDistance;
    public AudioSource humanoidAudioSource;
    bool isClose;
    // Start is called before the first frame update
    void Start()
    {
        humanoidAnimator.GetComponent<Animator>();   
        humanoidAudioSource.GetComponent<AudioSource>();
        InvokeRepeating("checkDistance", 0f, 4f);
    }

    // Update is called once per frame
    void checkDistance() {
        isClose = false;
        if (Vector3.Distance(gameObject.transform.localPosition, mainPlayset.transform.localPosition) <= minimumDistance) {
            isClose = true;
        }
        if (isClose) {
            StartCoroutine(animate());
        }
    }

    IEnumerator animate() {
        humanoidAnimator.SetTrigger("TriggerShout");
        humanoidAudioSource.Play();
        yield return new WaitForSeconds(humanoidAudioSource.clip.length);
        isClose = false;
    }
}
