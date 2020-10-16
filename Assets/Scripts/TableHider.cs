using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableHider : MonoBehaviour
{
    MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (meshRenderer.enabled) {
            meshRenderer.enabled = false;
        }
    }
}
