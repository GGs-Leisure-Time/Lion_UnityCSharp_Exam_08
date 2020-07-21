using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Runner runner;
    [Header("結束畫面標題")]
    public Text textTitle;
    [Header("結束畫面")]
    public CanvasGroup final;
    // Start is called before the first frame update
    void Start()
    {
        runner.arrive += End;
    }

    private void End()
    {
        final.alpha = 1;
        final.interactable = true;
        final.blocksRaycasts = true;
        textTitle.text = "GOAL!!!!!!!";
        //取得玩家.啟動 = false
        FindObjectOfType<Runner>().enabled = false;
    }

    public void BackQ()
    {
        SceneManager.LoadScene("Question3");
    }

    public void NextQ()
    {
        SceneManager.LoadScene("Question5");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("Question3");
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Question5");
        }

    }
}
