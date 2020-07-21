using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Q2UIButton : MonoBehaviour
{

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