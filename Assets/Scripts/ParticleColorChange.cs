using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleColorChange : MonoBehaviour
{
    public Renderer me;

    // Start is called before the first frame update
    private void Start()
    {
        me.material.color = Color.blue;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}