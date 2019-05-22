using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Älä koske tänne!
/// </summary>
public class MissionBox : MonoBehaviour
{
    public enum MISSION { MOVEMENT, JUMP, CAMERA, COMPONENTS, COLLECTABLES, REFERENCES, UI, QUESTIONS };
    public MISSION mission;

    Text instructions;
    
    private void Awake()
    {
        instructions = GameObject.Find("T_Instructions").GetComponent<Text>();
    }

    private void Start()
    {
        instructions.alignment = TextAnchor.MiddleCenter;
        instructions.text = "Klikkaa huutomerkkiä!";
    }


    private void OnMouseDown()
    {
        instructions.alignment = TextAnchor.UpperLeft;
        switch (mission)
        {
            case MISSION.MOVEMENT:
                instructions.text = "Laita pelaaja liikkumaan vasemmalle ja oikealle\nMuista lisätä oikeat komponentit.";
                break;
            case MISSION.CAMERA:
                instructions.text = "Aseta kamera seuraamaan pelaajaa.";
                break;
            case MISSION.COMPONENTS:
                instructions.text = "Lisää laatikoihin tarvittavat komponentit, jotta ne voivat pudota kuoppaan.";
                break;
            case MISSION.COLLECTABLES:
                instructions.text = "Lisää timantteihin oikeat komponentit, jotta että voit kerätä niitä.";
                break;
            case MISSION.JUMP:
                instructions.text = "Laita pelaaja hyppäämään";
                break;
            case MISSION.REFERENCES:
                instructions.text = "Lisää MISSING_COMPONENTS -objektiin puuttuvat komponentit. Niistä tulee ilmoitus consoleen.";
                break;
            case MISSION.UI:
                instructions.text = "Kun pelaaja kerää timantin, hän joko saa pisteitä tai laskee kerättyjen timanttien lukumäärää. Laita se näkymään ruudulla";
                break;
            case MISSION.QUESTIONS:
                instructions.text = "Avaa Questions.cs Scripts-kansiosta ja vastaa kysymyksiin";
                break;
        }
        
    }
}
