using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public const int numberOfLiberalCards = 6;
    public const int numberOfFascistCards = 11;

    public static string[] policies = { "L", "F" };

    public PlayerManager PlayerManager;

    public Sprite[] policySprites;

    public List<string> policyDeck;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public List<string> GenerateDeck()
    {
        var newDeck = new List<string>();

        for (int i = 0; i < numberOfLiberalCards; i++)
        {
            newDeck.Add("L");
        }

        for (int i = 0; i < numberOfFascistCards; i++)
        {
            newDeck.Add("F");
        }

        return newDeck;
    }

    void Shuffle<T>(List<T> list)
    {
        System.Random random = new System.Random();
        int n = list.Count;

        while (n > 1)
        {
            int k = random.Next();
            n--;
            T temp = list[k];
            list[k] = list[n];
            list[n] = temp;
        }

    }
}
