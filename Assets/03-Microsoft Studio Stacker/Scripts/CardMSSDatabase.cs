using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMSSDatabase : MonoBehaviour
{
    public static List<CardMSS> conceptCardList = new List<CardMSS>();
    public static List<CardMSS> studioCardList = new List<CardMSS>();
    

    private void Awake()
    {
        //add member cards to cardList
        studioCardList.Add(new CardMSS(0, "Alexis Novotny", 2, 0, 0, 0, "Senior Team Member", "", 0));
        studioCardList.Add(new CardMSS(3, "Antonio Greco", 1, 1, 1, 1, "Team Member", "", 0));
        studioCardList.Add(new CardMSS(4, "Alain Pellerin", 0, 0, 2, 1, "Senior Team Member", "", 0));
        studioCardList.Add(new CardMSS(5, "Cassandra Simon", 1, 0, 0, 2, "Senior Team Member", "", 0));
        studioCardList.Add(new CardMSS(6, "Malorie Monjeau", 0, 0, 1, 2, "Senior Team Member", "", 0));
        studioCardList.Add(new CardMSS(7, "Logan Lamontagne", 0, 2, 1, 0, "Senior Team Member", "", 0));
        studioCardList.Add(new CardMSS(8, "Kristina Tomic", 1, 1, 1, 1, "Team Member", "", 0));
        studioCardList.Add(new CardMSS(9, "Lidia Wilkinson", 1, 1, 1, 1, "Team Member", "", 0));
        studioCardList.Add(new CardMSS(10, "Predan Pavlovic", 1, 1, 1, 1, "Team Member", "", 0));



        //add studio event cards to cardList
        studioCardList.Add(new CardMSS(1, "Use that PTO", 0, 0, 0, 0, "Zero 1 phase - Choose an opposing syudio and set 1 development phase to 0 skill points for this turn. They must immediately resolve their game development journey.", "", 0));



        //add concept cards to cardList
        conceptCardList.Add(new CardMSS(0, "Pew Pew Pew", 1, 1, 1, 1, "a rooty tooty blast and shooty good time", "Blue", 1));



        //add publish event cards to cardList
        studioCardList.Add(new CardMSS(2, "Alexis Novotny", 0, 0, 0, 0, "Senior Team Member", "Red", 1));
    }

}
