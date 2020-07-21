using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Q3UIButton : MonoBehaviour
{
    public void BackQ()
    {
        SceneManager.LoadScene("Question2");
    }

    public void NextQ()
    {
        SceneManager.LoadScene("Question4");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("Question2");
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Question4");
        }

    }
}
