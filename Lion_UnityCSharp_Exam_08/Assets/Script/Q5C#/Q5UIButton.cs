using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Q5UIButton : MonoBehaviour
{
    public void BackQ()
    {
        SceneManager.LoadScene("Question4");
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("Question4");
        }
    }
}
