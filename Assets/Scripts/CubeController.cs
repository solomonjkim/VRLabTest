using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    MeshRenderer cubeRenderer;
    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = GetComponent<MeshRenderer>();
    }

    void OnTriggerEnter(Collider other)
    {
        cubeRenderer.enabled = false;
    }

    void OnTriggerExit(Collider other)
    {
        cubeRenderer.enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
