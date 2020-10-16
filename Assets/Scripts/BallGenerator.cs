using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject redBall;
    public int number;
    float radius;
    // Start is called before the first frame update
    void Start()
    {
        radius = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            for (int i = 0; i < number; i++) {
                float angle = i * Mathf.PI * 2 / number;
                float x = Mathf.Cos(angle) * Random.Range(0f, radius);
                float z = Mathf.Sin(angle) * Random.Range(0f, radius);
                Vector3 pos = transform.position + new Vector3(x, 0, z);
                float angleDegrees = -angle * Mathf.Rad2Deg;
                Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
                Instantiate(redBall, pos, rot);
            }
        }
    }
}
