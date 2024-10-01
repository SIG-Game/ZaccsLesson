using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    Color[] colors = {Color.black, Color.blue, Color.red,
                    Color.cyan, Color.green, Color.magenta,
                    Color.white, Color.yellow, Color.gray};
    private Renderer renderer;
    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShiftColor();
        }
    }

    public void ShiftColor()
    {
        Color randomColor = colors[Random.Range(0, 9)];
        renderer.material.color = randomColor;
        count++;
    }

    public Color ReturnColor()
    {
        return renderer.material.color;
    }
}
