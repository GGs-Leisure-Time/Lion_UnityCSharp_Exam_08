using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Q2 : MonoBehaviour
{
    public Sprite[] item = new Sprite[25];
    public SpriteRenderer lottery;

    public void RandomLottery()
    {
        lottery.sprite = item[Random.Range(0,24)];
    }

}
