using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CardDisplay : MonoBehaviour
{
    public TMP_Text cardName;
    public TMP_Text cardAtk;
    public TMP_Text cardHp;
    public TMP_Text cardDes;
    public Card card;

    // Start is called before the first frame update
    void Start()
    {
        ShowCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCard()
    {

        cardName.text = card.name;
        if (card is MonsterCard)
        {
            var monster = card as MonsterCard;
            cardAtk.text = monster.atk.ToString();
            cardHp.text = monster.hp.ToString();
            cardDes.gameObject.SetActive(false);
        }else if (card is MagicCard)
        {
            var magic = card as MagicCard;
            cardDes.text = magic.effect;
            cardAtk.gameObject.SetActive(false);
            cardHp.gameObject.SetActive(false);

        }


    }
}
