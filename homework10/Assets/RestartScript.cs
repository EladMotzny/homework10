using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RestartScript : MonoBehaviour
{
    public TextMeshProUGUI gameOverDisplay;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerMovement.collectedAll == true)
        {
            gameOverDisplay.text = "You collected all the coins! Press R to restart";
        }
        else
        {
            gameOverDisplay.text = "You still have coins to collect. Press R to try again";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("WallJump");
        }
    }
}
