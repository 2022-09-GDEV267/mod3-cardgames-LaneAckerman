using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class CardMSS
{
    public int id;
    public string cardName;
    public int design;
    public int build;
    public int test;
    public int publish;
    public string genreColor;
    public string cardDescription;
    public int gameValue;

    public CardMSS()
    {

    }


    public CardMSS(int Id, string CardName, int Design, int Build, int Test, int Publish, string CardDescription, string GenreColor, int GameValue)
    {
        id = Id;
        cardName = CardName;
        build = Build;
        design = Design;
        test = Test;
        publish = Publish;
        cardDescription = CardDescription;
        genreColor = GenreColor;
        gameValue = GameValue;
    }

}
