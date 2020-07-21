using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Q3 : MonoBehaviour
{
    public GameObject Cube;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < (i + 1); j++)
            {
                Vector3 pos = new Vector3(i  , j , 50);
                Instantiate(Cube, pos, Quaternion.identity);
                Vector3 pos2 = new Vector3(i, -j, 50);
                Instantiate(Cube, pos2, Quaternion.identity);
                Vector3 pos3 = new Vector3(-i+18  , j , 50);
                Instantiate(Cube, pos3, Quaternion.identity);
                Vector3 pos4 = new Vector3(-i+18, -j, 50);
                Instantiate(Cube, pos4, Quaternion.identity);
            }
        }
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
