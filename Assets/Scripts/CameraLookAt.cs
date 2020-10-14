using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    public GameObject cubey;
    public GameObject cubey2;
    public GameObject cubey3;
    public GameObject cubey4;
    public GameObject cubey5;
    public int whichCubeToView;
    public float camSpeed;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (whichCubeToView == 5 || whichCubeToView == 0)
            {
                whichCubeToView = 1;
            }
            else
                whichCubeToView++;
        }
        if (whichCubeToView == 1)
        {
            transform.LookAt(cubey.transform.position);
        }
        if (whichCubeToView == 2)
        {
            transform.LookAt(cubey2.transform.position);
        }
        if (whichCubeToView == 3)
        {
            transform.LookAt(cubey3.transform.position);
        }
        if (whichCubeToView == 4)
        {
            transform.LookAt(cubey4.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, cubey3.transform.position, camSpeed);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.LookAt(cubey5.transform.position);
        }
    }
}