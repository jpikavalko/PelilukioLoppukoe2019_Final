using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionBox : MonoBehaviour
{
    public enum MISSION { MOVEMENT, JUMP, CAMERA, COMPONENTS, COLLECTABLES, REFERENCES, UI, ANIMATIONS };
    public MISSION mission;

    Text instructions;
    
    private void Awake()
    {
        instructions = GameObject.Find("T_Instructions").GetComponent<Text>();
    }

    private void Start()
    {
        instructions.alignment = TextAnchor.MiddleCenter;
        instructions.text = "Klikkaa hiirellä laatikoita, joissa on huutomerkki\nNiitä on yhteensä 7 kappaletta";
    }


    private void OnMouseDown()
    {
        instructions.alignment = TextAnchor.UpperLeft;
        switch (mission)
        {
            case MISSION.MOVEMENT:
                instructions.text = "Laita pelaaja liikkumaan vasemmalle ja oikealle\nMuista lisätä oikeat komponentit pelaajalle.";
                break;
            case MISSION.CAMERA:
                instructions.text = "Aseta kamera seuraamaan pelaajaa.";
                break;
            case MISSION.COMPONENTS:
                instructions.text = "Lisää molempiin laatikoihin tarvittavat komponentit, jotta ne voivat pudota rotkoon.";
                break;
            case MISSION.COLLECTABLES:
                instructions.text = "Lisää timantteihin oikeat komponentit ja scripti, niin että voit kerätä niitä.";
                break;
            case MISSION.JUMP:
                instructions.text = "Laita pelaaja hyppäämään";
                break;
            case MISSION.REFERENCES:
                instructions.text = "REFERENCES";
                break;
            case MISSION.UI:
                instructions.text = "Kun pelaaja kerää timantin, hän joko saa pisteitä tai laskee kerättyjen timanttien lukumäärää. Laita se näkymään ruudulla";
                break;
            case MISSION.ANIMATIONS:
                instructions.text = "ANIMATIONS";
                break;
        }
        
    }
}
