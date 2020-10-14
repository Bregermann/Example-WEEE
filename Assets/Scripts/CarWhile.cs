using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarWhile : MonoBehaviour
{
    private float makeMeRotate = 29997;

    // Update is called once per frame
    private void Update()
    {
        while (makeMeRotate > 0)
        {
            this.gameObject.transform.rotation = Quaternion.Euler(Random.Range(1, 277), Random.Range(1, 277), makeMeRotate);
            makeMeRotate--;
        }
    }
}