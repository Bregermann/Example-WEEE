using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBuilder : MonoBehaviour
{
    public int buildTimer;
    public int[] sizes;
    public int[] sizeIndex;

    // Start is called before the first frame update
    private void Start()
    {
        buildTimer = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        buildTimer++;
        if (buildTimer == 50)
        {
            gameObject.AddComponent<BoxCollider>();
        }
        if (buildTimer == 100)
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.AddComponent<ParticleSystem>();
            ParticleSystem meColor;
            meColor = gameObject.GetComponent<ParticleSystem>();
            meColor.particleCount.Equals(9000000000);
        }
        if (buildTimer == 150)
        {
            Renderer thisGuy;
            thisGuy = gameObject.GetComponent<MeshRenderer>();
            thisGuy.material.color = Color.magenta;
        }
        if (buildTimer == 200)
        {
            gameObject.transform.localScale = new Vector3(12, 15, 17);
            gameObject.GetComponent<BoxCollider>().enabled = true;
        }
        if (buildTimer == 250)
        {
            gameObject.transform.localScale = new Vector3(Random.Range(1, 90), Random.Range(1, 90), Random.Range(1, 90));
        }
        if (buildTimer == 300)
        {
            buildTimer = 151;
        }
    }
}