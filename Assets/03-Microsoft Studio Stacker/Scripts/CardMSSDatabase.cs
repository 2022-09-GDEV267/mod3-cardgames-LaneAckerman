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
        studioCardList.Add(new CardMSS(0, "Alexis Novotny", 2, 0, 0, 0, "Senior Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(3, "Antonio Greco", 1, 1, 1, 1, "Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(4, "Alain Pellerin", 0, 0, 2, 1, "Senior Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(5, "Cassandra Simon", 1, 0, 0, 2, "Senior Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(6, "Malorie Monjeau", 0, 0, 1, 2, "Senior Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(7, "Logan Lamontagne", 0, 2, 1, 0, "Senior Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(8, "Kristina Tomic", 1, 1, 1, 1, "Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(9, "Lidia Wilkinson", 1, 1, 1, 1, "Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(10, "Predan Pavlovic", 1, 1, 1, 1, "Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(11, "Murray Yoo", 1, 1, 1, 1, "Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(12, "Clarisa Baresi", 1, 1, 1, 1, "Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(13, "Francesco Greco", 2, 0, 0, 0, "Senior Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(14, "Pamet Jovovich", 0, 2, 0, 0, "Senior Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(15, "Ira Orth", 0, 1, 2, 0, "Senior Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(16, "Eleanor Patel", 1, 2, 3, 1, "Lead Team Member - Whyen played, draw 1 Studio Deck card.", "", 0, "Member"));
        studioCardList.Add(new CardMSS(17, "Tricia Cooper", 2, 0, 0, 0, "Senior Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(18, "Hazel Maldonado", 0, 2, 0, 0, "Senior Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(19, "Jelena Kovacevic", 2, 0, 1, 0, "Senior Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(20, "Darnell Valenti", 2, 0, 1, 0, "Senior Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(21, "Manchu Lo", 2, 0, 0, 0, "Senior Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(22, "Vitor Cardoso", 1, 1, 1, 1, "Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(23, "Vitoria Mancini", 0, 2, 1, 0, "Senior Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(24, "Jose Pereira", 1, 1, 1, 1, "Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(25, "Ralph Musselman", 0, 0, 0, 2, "Senior Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(26, "Rosemarie Graham", 1, 1, 1, 1, "Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(27, "Jerry Zhao", 1, 0, 2, 0, "Senior Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(28, "Ebony Collier", 1, 1, 1, 1, "Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(29, "Manuel Araujo", 1, 1, 1, 1, "Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(30, "Wendell Sayre", 1, 3, 1, 2, "Lead Team Member - Whyen played, draw 1 Studio Deck card.", "", 0, "Member"));
        studioCardList.Add(new CardMSS(31, "Amparo Gardner", 1, 1, 1, 1, "Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(32, "Wendell Sayre", 3, 1, 2, 1, "Lead Team Member - Whyen played, draw 1 Studio Deck card.", "", 0, "Member"));
        studioCardList.Add(new CardMSS(33, "Laura Esposito", 1, 1, 1, 1, "Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(34, "Chan Wang", 1, 3, 2, 1, "Lead Team Member - Whyen played, draw 1 Studio Deck card.", "", 0, "Member"));
        studioCardList.Add(new CardMSS(2, "Opal Graham", 1, 2, 1, 3, "Lead Team Member - Whyen played, draw 1 Studio Deck card.", "", 0, "Member"));
        studioCardList.Add(new CardMSS(48, "Luzia Cunha", 2, 0, 0, 0, "Senior Team Member", "", 0, "Member"));
        studioCardList.Add(new CardMSS(49, "Cynthia Bailey", 1, 1, 1, 1, "Team Member", "", 0, "Member"));






        //add studio event cards to cardList
        studioCardList.Add(new CardMSS(1, "Use that PTO", 0, 0, 0, 0, "Zero 1 phase - Choose an opposing studio and set 1 development phase to 0 skill points for this turn. They must immediately resolve their game development journey.", "", 0, "SEvent"));
        studioCardList.Add(new CardMSS(35, "Inspiration from remote locations", 0, 0, 0, 0, "Skip 1 phase - Immediately advance 1 active game concept 1 game development phase.", "", 0, "SEvent"));
        studioCardList.Add(new CardMSS(36, "Corporate buzzwords", 0, 0, 0, 0, "Studio Upgrade - you may move all active team members in your studio. Resolve game development journey after studio is set.", "", 0, "SEvent"));
        studioCardList.Add(new CardMSS(37, "We've got this", 0, 0, 0, 0, "Skip 2 phases - Immediately advance 1 active game concept 2 game development phases.", "", 0, "SEvent"));
        studioCardList.Add(new CardMSS(38, "And you get a promotion!", 0, 0, 0, 0, "Studio Upgrade - you may move all active team members in your studio. Resolve game development journey after studio is set.", "", 0, "SEvent"));
        studioCardList.Add(new CardMSS(39, "Food poisoning", 0, 0, 0, 0, "Zero 1 phase - Choose an opposing syudio and set 1 development phase to 0 skill points for this turn. They must immediately resolve their game development journey.", "", 0, "SEvent"));
        studioCardList.Add(new CardMSS(40, "Not my first rodeo", 0, 0, 0, 0, "Skip 2 phases - Immediately advance 1 active game concept 2 game development phases.", "", 0, "SEvent"));
        studioCardList.Add(new CardMSS(41, "Kittens! Hnnnng", 0, 0, 0, 0, "Zero 1 phase - Choose an opposing syudio and set 1 development phase to 0 skill points for this turn. They must immediately resolve their game development journey.", "", 0, "SEvent"));
        studioCardList.Add(new CardMSS(42, "Out of order", 0, 0, 0, 0, "Zero 1 phase - Choose an opposing syudio and set 1 development phase to 0 skill points for this turn. They must immediately resolve their game development journey.", "", 0, "SEvent"));
        studioCardList.Add(new CardMSS(43, "Where's the fire?", 0, 0, 0, 0, "Zero 1 phase - Choose an opposing syudio and set 1 development phase to 0 skill points for this turn. They must immediately resolve their game development journey.", "", 0, "SEvent"));
        studioCardList.Add(new CardMSS(44, "Not in my job description", 0, 0, 0, 0, "Studio Upgrade - you may move all active team members in your studio. Resolve game development journey after studio is set.", "", 0, "SEvent"));
        studioCardList.Add(new CardMSS(45, "Test time dilation", 0, 0, 0, 0, "Skip 1 phase - Immediately advance 1 active game concept 1 game development phase.", "", 0, "SEvent"));
        studioCardList.Add(new CardMSS(46, "Cloud 9", 0, 0, 0, 0, "Skip 1 phase - Immediately advance 1 active game concept 1 game development phase.", "", 0, "SEvent"));
        studioCardList.Add(new CardMSS(47, "More room for snacks", 0, 0, 0, 0, "Skip 1 phase - Immediately advance 1 active game concept 1 game development phase.", "", 0, "SEvent"));


        //add concept cards to cardList
        conceptCardList.Add(new CardMSS(0, "Pew Pew Pew", 1, 1, 1, 1, "a rooty tooty blast and shooty good time", "Blue", 1, "Concept"));
        conceptCardList.Add(new CardMSS(1, "Sepsis", 1, 1, 1, 1, "Connect multicolored blocks to clear tones of buildings in Siberia", "Green", 1, "Concept"));
        conceptCardList.Add(new CardMSS(2, "Pocket Ma Stores", 1, 1, 1, 2, "A young child departs on a magical adventure to collect all 150 trinkets for their mother's antique shop", "Green", 1, "Concept"));
        conceptCardList.Add(new CardMSS(3, "Meteorvania", 2, 3, 1, 2, "Alone warrior navigates a labyrinthian maze and fights space vampires", "Blue/Orange", 2, "Concept"));
        conceptCardList.Add(new CardMSS(4, "Post-Fight Plastic Surgeon", 2, 2, 2, 2, "Someone's gotta patch up these folks after their cage matches and wierd kung fu fireballs", "Green/Blue", 2, "Concept"));
        conceptCardList.Add(new CardMSS(5, "Fender Bender Splendor", 3, 2, 2, 1, "Smash cars together for a high score and cross your fingers that insurance covers it", "Blue/Orange", 2, "Concept"));
        conceptCardList.Add(new CardMSS(6, "Super Road Brawler 2: Hyper Battles", 1, 1, 1, 1, "Rambling Karate Man travles the world fighting a cavalcade of wacky opponents", "Orange", 1, "Concept"));
        conceptCardList.Add(new CardMSS(7, "Warlocksmith: Rise of the Witchomatons", 2, 3, 1, 2, "Use your magic and lock picking skills to prevent the return of a robot witch cult", "Green/Orange", 2, "Concept"));
        conceptCardList.Add(new CardMSS(8, "Fuzzy Critter Friend Town", 1, 2, 2, 1, "You're the new ambushman of your very own town of adorable talking animals", "Green", 1, "Concept"));
        conceptCardList.Add(new CardMSS(9, "MBA Hoops", 1, 2, 1, 1, "Business majors settle their differences on the court", "Orange", 1, "Concept"));
        conceptCardList.Add(new CardMSS(10, "CryoSpark Forever", 3, 3, 2, 3, "You're about to ruin this beautiful steampunk city, and it's gonna rule", "Blue", 3, "Concept"));
        conceptCardList.Add(new CardMSS(11, "Jikan no Muda", 2, 3, 3, 3, "A mystical quest over a sprawling world with enough sidequests and characters to replace your real life", "Green", 3, "Concept"));
        conceptCardList.Add(new CardMSS(12, "Pew Pew Pew", 1, 1, 1, 1, "a rooty tooty blast and shooty good time", "Blue", 1, "Concept"));
        conceptCardList.Add(new CardMSS(13, "Pew Pew Pew", 1, 1, 1, 1, "a rooty tooty blast and shooty good time", "Blue", 1, "Concept"));
        conceptCardList.Add(new CardMSS(14, "Pew Pew Pew", 1, 1, 1, 1, "a rooty tooty blast and shooty good time", "Blue", 1, "Concept"));
        conceptCardList.Add(new CardMSS(15, "Pew Pew Pew", 1, 1, 1, 1, "a rooty tooty blast and shooty good time", "Blue", 1, "Concept"));
        conceptCardList.Add(new CardMSS(16, "Pew Pew Pew", 1, 1, 1, 1, "a rooty tooty blast and shooty good time", "Blue", 1, "Concept"));
        conceptCardList.Add(new CardMSS(17, "Pew Pew Pew", 1, 1, 1, 1, "a rooty tooty blast and shooty good time", "Blue", 1, "Concept"));
        conceptCardList.Add(new CardMSS(18, "Pew Pew Pew", 1, 1, 1, 1, "a rooty tooty blast and shooty good time", "Blue", 1, "Concept"));
        conceptCardList.Add(new CardMSS(19, "Sepsis", 1, 1, 1, 1, "Connect multicolored blocks to clear tones of buildings in Siberia", "Green", 1, "Concept"));
        conceptCardList.Add(new CardMSS(20, "Sepsis", 1, 1, 1, 1, "Connect multicolored blocks to clear tones of buildings in Siberia", "Green", 1, "Concept"));
        conceptCardList.Add(new CardMSS(21, "Sepsis", 1, 1, 1, 1, "Connect multicolored blocks to clear tones of buildings in Siberia", "Green", 1, "Concept"));
        conceptCardList.Add(new CardMSS(22, "Sepsis", 1, 1, 1, 1, "Connect multicolored blocks to clear tones of buildings in Siberia", "Green", 1, "Concept"));
        conceptCardList.Add(new CardMSS(23, "Sepsis", 1, 1, 1, 1, "Connect multicolored blocks to clear tones of buildings in Siberia", "Green", 1, "Concept"));
        conceptCardList.Add(new CardMSS(24, "Sepsis", 1, 1, 1, 1, "Connect multicolored blocks to clear tones of buildings in Siberia", "Green", 1, "Concept"));
        conceptCardList.Add(new CardMSS(25, "Sepsis", 1, 1, 1, 1, "Connect multicolored blocks to clear tones of buildings in Siberia", "Green", 1, "Concept"));
        conceptCardList.Add(new CardMSS(26, "Pocket Ma Stores", 1, 1, 1, 2, "A young child departs on a magical adventure to collect all 150 trinkets for their mother's antique shop", "Green", 1, "Concept"));
        conceptCardList.Add(new CardMSS(27, "Pocket Ma Stores", 1, 1, 1, 2, "A young child departs on a magical adventure to collect all 150 trinkets for their mother's antique shop", "Green", 1, "Concept"));
        conceptCardList.Add(new CardMSS(28, "Pocket Ma Stores", 1, 1, 1, 2, "A young child departs on a magical adventure to collect all 150 trinkets for their mother's antique shop", "Green", 1, "Concept"));
        conceptCardList.Add(new CardMSS(29, "Pocket Ma Stores", 1, 1, 1, 2, "A young child departs on a magical adventure to collect all 150 trinkets for their mother's antique shop", "Green", 1, "Concept"));
        conceptCardList.Add(new CardMSS(30, "Pocket Ma Stores", 1, 1, 1, 2, "A young child departs on a magical adventure to collect all 150 trinkets for their mother's antique shop", "Green", 1, "Concept"));
        conceptCardList.Add(new CardMSS(31, "Pocket Ma Stores", 1, 1, 1, 2, "A young child departs on a magical adventure to collect all 150 trinkets for their mother's antique shop", "Green", 1, "Concept"));
        conceptCardList.Add(new CardMSS(32, "Pocket Ma Stores", 1, 1, 1, 2, "A young child departs on a magical adventure to collect all 150 trinkets for their mother's antique shop", "Green", 1, "Concept"));
        conceptCardList.Add(new CardMSS(35, "Meteorvania", 2, 3, 1, 2, "Alone warrior navigates a labyrinthian maze and fights space vampires", "Blue/Orange", 2, "Concept"));
        conceptCardList.Add(new CardMSS(36, "Meteorvania", 2, 3, 1, 2, "Alone warrior navigates a labyrinthian maze and fights space vampires", "Blue/Orange", 2, "Concept"));
        conceptCardList.Add(new CardMSS(37, "Meteorvania", 2, 3, 1, 2, "Alone warrior navigates a labyrinthian maze and fights space vampires", "Blue/Orange", 2, "Concept"));
        conceptCardList.Add(new CardMSS(38, "Meteorvania", 2, 3, 1, 2, "Alone warrior navigates a labyrinthian maze and fights space vampires", "Blue/Orange", 2, "Concept"));
        conceptCardList.Add(new CardMSS(39, "Meteorvania", 2, 3, 1, 2, "Alone warrior navigates a labyrinthian maze and fights space vampires", "Blue/Orange", 2, "Concept"));
        conceptCardList.Add(new CardMSS(40, "Meteorvania", 2, 3, 1, 2, "Alone warrior navigates a labyrinthian maze and fights space vampires", "Blue/Orange", 2, "Concept"));
        conceptCardList.Add(new CardMSS(41, "Post-Fight Plastic Surgeon", 2, 2, 2, 2, "Someone's gotta patch up these folks after their cage matches and wierd kung fu fireballs", "Green/Blue", 2, "Concept"));
        conceptCardList.Add(new CardMSS(42, "Post-Fight Plastic Surgeon", 2, 2, 2, 2, "Someone's gotta patch up these folks after their cage matches and wierd kung fu fireballs", "Green/Blue", 2, "Concept"));
        conceptCardList.Add(new CardMSS(43, "Post-Fight Plastic Surgeon", 2, 2, 2, 2, "Someone's gotta patch up these folks after their cage matches and wierd kung fu fireballs", "Green/Blue", 2, "Concept"));
        conceptCardList.Add(new CardMSS(44, "Post-Fight Plastic Surgeon", 2, 2, 2, 2, "Someone's gotta patch up these folks after their cage matches and wierd kung fu fireballs", "Green/Blue", 2, "Concept"));
        conceptCardList.Add(new CardMSS(45, "Post-Fight Plastic Surgeon", 2, 2, 2, 2, "Someone's gotta patch up these folks after their cage matches and wierd kung fu fireballs", "Green/Blue", 2, "Concept"));
        conceptCardList.Add(new CardMSS(46, "CryoSpark Forever", 3, 3, 2, 3, "You're about to ruin this beautiful steampunk city, and it's gonna rule", "Blue", 3, "Concept"));
        conceptCardList.Add(new CardMSS(47, "Jikan no Muda", 2, 3, 3, 3, "A mystical quest over a sprawling world with enough sidequests and characters to replace your real life", "Green", 3, "Concept"));
        conceptCardList.Add(new CardMSS(48, "Fuzzy Critter Friend Town", 1, 2, 2, 1, "You're the new ambushman of your very own town of adorable talking animals", "Green", 1, "Concept"));
        conceptCardList.Add(new CardMSS(49, "MBA Hoops", 1, 2, 1, 1, "Business majors settle their differences on the court", "Orange", 1, "Concept"));



        //add publish event cards to cardList
        //studioCardList.Add(new CardMSS(2, "Alexis Novotny", 0, 0, 0, 0, "Senior Team Member", "Red", 1, "PEvent"));
    }

}
