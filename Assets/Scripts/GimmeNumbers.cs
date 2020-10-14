using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmeNumbers : MonoBehaviour
{
    public int thiccLoot;
    public Renderer cubeyMcCubeFace;

    public float rotationSpeed;
    public bool redGreen;

    public int countEmUp;

    // Start is called before the first frame update
    private void Start()
    {
        rotationSpeed = 1006;
        redGreen = true;
    }

    // Update is called once per frame
    private void Update()
    {
        countEmUp++;
        transform.Rotate(0, 0, countEmUp * Time.deltaTime);
        if (redGreen == true)
        {
            thiccLoot = 1;
        }
        else
        {
            thiccLoot = 10;
        }

        if (thiccLoot == 1)
        {
            cubeyMcCubeFace.material.color = Color.blue;
        }
        if (thiccLoot == 10)
        {
            cubeyMcCubeFace.material.color = Color.green;
        }
        if (countEmUp > 100)
        {
            redGreen = false;
        }
        if (countEmUp == 200)
        {
            redGreen = true;
            countEmUp = 0;
        }
    }
}