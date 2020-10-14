using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendMeBack : MonoBehaviour
{
    public Transform whereTo;
    public GameObject respawnPoint;

    // Start is called before the first frame update
    private void Start()
    {
        whereTo = respawnPoint.transform;
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = whereTo.position;
    }
}