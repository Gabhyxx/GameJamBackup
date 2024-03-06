using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharNameGenerator : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameFirst;
    [SerializeField] private TextMeshProUGUI nameLast;
    [SerializeField] private TextMeshProUGUI nameCrime;
    [SerializeField] private TextMeshProUGUI nameDescription1;
    [SerializeField] private TextMeshProUGUI nameDescription2;
    [SerializeField] private TextMeshProUGUI nameDescription3;
    [SerializeField] GameObject[] character;
    [SerializeField] GameObject[] characterDocument;


    int index;

    List<string> firstNames = new List<string>
    {
        "Giovanni", "Orville", "Su-yeol", "Francisco", "Pickle", "Hammer"
    };

    List<string> lastNames = new List<string>
    {
        "Sweetie", "Cheesecake", "Christopher", "García Ponce", "Toffee", "Sampson"
    };

    List<string> crimes = new List<string>
    {
        "Being more handsome than our lider", "Stealing public property", "Murdering", "Necrophilia", "Assault", "Treason"
    };

    List<string> description1 = new List<string>
    {
        "Dumb", "Smart", "Reckless", "Nice butt", "Mother has depression", "Has depression"
    };

    List<string> description2 = new List<string>
    {
        "Tall", "Lost & Damned", "Robotic", "Good at commiting crimes", "Worked as a Hitman in the 90s", "Likes to drink clown's blood"
    };

    List<string> description3 = new List<string>
    {
        "Fighter", "Pyromaniac", "Tax Evader", "Likes to think on a nudist beach", "It's a programmer", "Cousin is an A+ stripper"
    };

    private void Start()
    {
        for (int i = 0; i < firstNames.Count; i++)
        {
           IndexGenerator();
            int varia = index;
            nameFirst.text = firstNames[index];
            nameLast.text = lastNames[index];
            nameCrime.text = crimes[index];
            nameDescription1.text = description1[index];
            nameDescription2.text = description2[index];
            nameDescription3.text = description3[index];
        }
    }

    void CharacterSelector()
    {
        
    }

    void IndexGenerator()
    {
        index = Random.Range(0, firstNames.Count);
        //Debug.Log("Indice generado: " + index);                                     
    }
}
