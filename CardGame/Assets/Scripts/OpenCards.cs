using Microsoft.Win32.SafeHandles;
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
    List<GameObject> cards = new List<GameObject>();
    void Start()
    {
       cardStore = GetComponent<CardStore>();
    }
    public void ChouKa()
    {
        ClearPool();
        for (int i = 0; i < 5; i++)
        {
            // GameObject newCard = GameObject.Instantiate(cardPrefab,cardPool.transform);
            // newCard.GetComponent<CardDisplay>().card = cardStore.RandomCard();
            // Debug.Log(newCard.GetComponent<CardDisplay>().card.name);
            cards.Add(GameObject.Instantiate(cardPrefab,cardPool.transform));
            cards[i].GetComponent<CardDisplay>().card = cardStore.RandomCard();
        }
        
    }
    void ClearPool()
    {
        foreach (var item in cards)
        {
            Destroy(item);
        }
        cards.Clear();

    }

}
