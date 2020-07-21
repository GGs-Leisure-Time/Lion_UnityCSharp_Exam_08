using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Q1UIButton : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("Question5");
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Question2");
        }
    }
}
