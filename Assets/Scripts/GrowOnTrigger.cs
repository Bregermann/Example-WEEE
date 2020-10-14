using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowOnTrigger : MonoBehaviour
{
    public float scaleMeUp;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerStay(Collider other)
    {
        scaleMeUp++;
        other.gameObject.transform.localScale = new Vector3(scaleMeUp, scaleMeUp, scaleMeUp);
    }
}