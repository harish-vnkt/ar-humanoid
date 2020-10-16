using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCat : MonoBehaviour
{   
    public GameObject target;
    Vector3 source;
    Vector3 destination;
    Quaternion targetRotation;
    float speed = 1;
    float t;
    // Start is called before the first frame update
    void Start()
    {
        targetRotation = transform.localRotation;
        speed = speed * transform.localScale.x;
        source = transform.localPosition;
        Debug.Log(source);
        destination = target.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * speed;
        transform.localPosition = Vector3.Lerp(source, destination, t);
        if (t >= 1) {
            var b = destination;
            var a = source;
            source = b;
            destination = a;
            t = 0;
            targetRotation *= Quaternion.AngleAxis(180, Vector3.up);
        }
        transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, 30 * speed * Time.deltaTime);

    }
}
