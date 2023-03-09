using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCards : MonoBehaviour
{

    // public GameObject cardPrefab;
    // public CardStore cardStore ;
    // 
    // {
    //     cardStore = GetComponent<CardStore>();
    // }
    // public void ChouKa()
    // {
    //     GameObject newcard = GameObject.Instantiate(cardPrefab);
    //     newcard.GetComponent<CardDisplay>().card = cardStore.RandomCard();
    // }
    public GameObject cardPrefab;
    public GameObject cardPool;
    CardStore cardStore;
    void Start()
    {
       cardStore = GetComponent<CardStore>();
    }
    public void ChouKa()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject newCard = GameObject.Instantiate(cardPrefab,cardPool.transform);
            newCard.GetComponent<CardDisplay>().card = cardStore.RandomCard();
            Debug.Log(newCard.GetComponent<CardDisplay>().card.name);
        }
        
    }

}
