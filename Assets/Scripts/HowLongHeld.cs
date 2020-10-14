using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowLongHeld : MonoBehaviour
{
    private float howLongHasThisBeenGoingOn;
    public Text tellMe;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            howLongHasThisBeenGoingOn = 0;
        }
        if (Input.GetKey(KeyCode.P))
        {
            howLongHasThisBeenGoingOn++;
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            tellMe.text = howLongHasThisBeenGoingOn.ToString() + "years or months?";
        }
    }
}