using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperIf : MonoBehaviour
{
    private bool ouch;
    private int painCounter;

    private GameObject particles;
    private GameObject sufferSpawn;
    public AudioSource sufferScream;
    private int scream;

    // Start is called before the first frame update
    private void Start()
    {
        particles = GameObject.Find("Suffering");
        sufferSpawn = GameObject.FindGameObjectWithTag("spawn");
    }

    // Update is called once per frame
    private void Update()
    {
        if (ouch == true && painCounter > 20 || painCounter < 0)
        {
            Suffering();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            ouch = true;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            painCounter++;
            Debug.Log(painCounter);
        }
    }

    private void FixedUpdate()
    {
        if (scream > 0)
        {
            scream--;
        }
    }

    private void Suffering()
    {
        for (int i = 0; i < painCounter && scream == 0; i++)
        {
            scream = 50;
            Instantiate(particles, sufferSpawn.transform);
            sufferScream.Play();
            sufferSpawn.transform.position = new Vector3(Random.Range(-170, 230), Random.Range(0, 250), Random.Range(-210, 210));
        }
    }
}