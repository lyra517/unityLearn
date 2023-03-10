//using System.ComponentModel.DataAnnotations;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStore : MonoBehaviour
{
    public TextAsset  cardData;
    public List<Card> cardList = new List<Card>();
    // Start is called before the first frame update
    void Start()
    {
        LoadCardData();
        Debug.Log(RandomCard().name) ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LoadCardData()
    {
        string[] cardRow = cardData.text.Split('\n');
        foreach (var count in cardRow)
        {
            string[] rowData = count.Split(',');
            if (rowData[0] == "??")
            {
                continue;
            }else if (rowData[0]=="monster")
            {
                int id = int.Parse(rowData[1]);
                string name = rowData[2];
                int atk = int.Parse(rowData[3]);
                int hp = int.Parse(rowData[4]);
                MonsterCard monster = new MonsterCard(id,name,atk,hp);
                cardList.Add(monster);
            }else if (rowData[0]=="magic")
            {
                int id = int.Parse(rowData[1]);
                string name = rowData[2];
                string des = rowData[3];
                MagicCard magic = new MagicCard(id,name,des);
                cardList.Add(magic);
            }            
        }
        // foreach (var card in cardList)
        //     {
        //         Debug.Log("name:"+card.id);
        //     }
    }
    public Card RandomCard()
    {        
        return cardList[Random.Range(0,cardList.Count)];
    }
}
