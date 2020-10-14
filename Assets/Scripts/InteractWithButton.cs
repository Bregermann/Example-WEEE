using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithButton : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerStay(Collider Player)
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            //button stuff happens
            //play any animations
            //have any events happen like a trap door
        }
    }
}