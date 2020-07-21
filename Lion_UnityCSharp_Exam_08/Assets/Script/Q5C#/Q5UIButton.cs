using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Q5UIButton : MonoBehaviour
{
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("Question4");
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Question1");
        }
    }
}
