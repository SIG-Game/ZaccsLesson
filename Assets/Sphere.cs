using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private Renderer renderer;
    private Rigidbody rigidbody;
    public int threshold;
    bool hasJumped = false;
    GameObject parentCube;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        rigidbody = GetComponent<Rigidbody>();
        parentCube = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        renderer.material.color = parentCube.GetComponent<Cube>().ReturnColor();

        if (parentCube.GetComponent<Cube>().count % 5 == threshold)
        {
            if (!hasJumped)
            {
                rigidbody.AddForce(new Vector3(0f, 400f, 0f), ForceMode.Force);
                hasJumped = true;
            }
        } else {
            hasJumped = false;
        }
    }
}
