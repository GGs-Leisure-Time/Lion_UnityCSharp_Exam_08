using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Q1UIButton : MonoBehaviour
{
    public void BackQ()
    {

    }

    public void NextQ()
    {
        SceneManager.LoadScene("Question2");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Question2");
        }
    }
}
