using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Q2UIButton : MonoBehaviour
{
    public void BackQ()
    {
        SceneManager.LoadScene("Question1");
    }

    public void NextQ()
    {
        SceneManager.LoadScene("Question3");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Question3");
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("Question1");
        }
    }
}