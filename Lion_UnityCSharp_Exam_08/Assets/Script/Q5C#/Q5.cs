using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Q5 : MonoBehaviour
{
    /// <summary>
    /// 52張撲克牌
    /// </summary>
    public List<GameObject> cards = new List<GameObject>();

    private string[] type = { "Spades", "Diamond", "Heart", "Club" };
    private string[] Num = { "A", "3", "5", "7", "9", "J", "K" };

    private void Start()
    {
        GetAllCard();
        StartSort();
    }

    private void GetAllCard()
    {
        //如果撲克牌數量等於52張就跳出
        if (cards.Count == 52) return;
        //四個花色
        for (int i = 0; i < type.Length; i++)
        {
            //1-13張
            for (int j = 1; j < 14; j++)
            {
                string number = j.ToString();

                switch (j)
                {
                    case 1:
                        number = "A";
                        break;
                    case 11:
                        number = "J";
                        break;
                    case 12:
                        number = "Q";
                        break;
                    case 13:
                        number = "K";
                        break;
                }

                //卡牌 = 素材.載入<遊戲物件>("素材名稱")
                GameObject card = Resources.Load<GameObject>("PlayingCards_" + number + type[i]);
                //添加卡牌
                cards.Add(card);
            }
        }
    }

    public void ChooseOdds()
    {
        DeleteAllChild();

        var sort = from card in cards
                   where card.name.Contains(Num[0]) || card.name.Contains(Num[1]) || card.name.Contains(Num[2]) || card.name.Contains(Num[3]) || card.name.Contains(Num[4]) || card.name.Contains(Num[5]) || card.name.Contains(Num[6])
                   select card;

        foreach (var item in sort) Instantiate(item, transform);

        StartCoroutine(SetChildPosition());
    }

    public void StartSort()
    {
        var sort = from card in cards
                   where card.name.Contains(type[3]) || card.name.Contains(type[2]) || card.name.Contains(type[1]) || card.name.Contains(type[0])
                   select card;

        foreach (var item in sort) Instantiate(item, transform);

        StartCoroutine(SetChildPosition());
    }

    /// <summary>
    /// 刪除所有子物件
    /// </summary>
    private void DeleteAllChild()
    {
        for (int i = 0; i < transform.childCount; i++) Destroy(transform.GetChild(i).gameObject);
    }

    /// <summary>
    /// 設定子物件座標:排序、大小、角度
    /// </summary>
    /// <returns></returns>
    private IEnumerator SetChildPosition()
    {
        //避免刪除此次的卡牌
        yield return new WaitForSeconds(0.1f);

        for (int i = 0; i < transform.childCount; i++)
        {
            //取得子物件
            Transform child = transform.GetChild(i);
            //設定角度
            child.eulerAngles = new Vector3(180, 0, 0);
            //設定尺寸
            child.localScale = Vector3.one * 20;
            //x = i%13 每13張都從1開始
            //x =(i-6)*間距
            float x = i % 13;
            //y=i/13 取得每一排的高度
            //4-y*間距
            int y = i / 13;
            child.position = new Vector3((x - 6) * 1.3f, 4 - y * 2, 0);

            yield return null;
        }
    }
}
