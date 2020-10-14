using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PressYToWin : MonoBehaviour
{
    public string holyMoley;
    public Text holyText;
    public int whichText;
    public AudioSource makeNoisesPls;

    public GameObject bread;

    // Start is called before the first frame update
    private void Start()
    {
        whichText = 9001;
        //bread.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (bread.gameObject.activeInHierarchy)
            {
                bread.SetActive(false);
            }
        }
        if (whichText > 9000)
        {
            holyText.text = "ITS OVER 9000!";
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            makeNoisesPls.Play();
            TextOfDestiny();
        }
        //Press Y to load the next level
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Debug.Log("I LIKE CHICKEN!");
            SceneManager.LoadScene(1);
        }
        holyText.text = holyMoley;
    }

    private void TextOfDestiny()
    {
        whichText = Random.Range(0, 3);
        if (whichText == 0)
        {
            holyMoley = "YOU PUT THAT BACK! YOU HEATHEN!";
        }
        if (whichText == 1)
        {
            holyMoley = "Hello there";
        }
        if (whichText == 2)
        {
            holyMoley = "That is not the instruction";
        }
        if (whichText == 3)
        {
            holyMoley = "VERY BAD!";
        }
    }
}