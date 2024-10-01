using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI text;
    private int numOfClicks = 0;
    private string clicksText = "# of clicks: ";
    // Start is called before the first frame update
    void Start()
    {
        UpdateNumClicks();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateNumClicks()
    {
        numOfClicks++;
        text.SetText(clicksText + numOfClicks.ToString());
    }
}
