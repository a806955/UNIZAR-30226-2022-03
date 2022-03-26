using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{

    public List<Card> displayCard = new List<Card>();


    public int displayId;

    public int id;
    public int valor;
    public string color;
    public string accion;
    public Sprite spriteImagen;

    public Image artImage;

    // Start is called before the first frame update
    void Start()
    {

        id = CardDatabase.cardList[displayId].id;
        valor = CardDatabase.cardList[displayId].valor;
        color = CardDatabase.cardList[displayId].color;
        accion = CardDatabase.cardList[displayId].accion;
        spriteImagen = CardDatabase.cardList[displayId].spriteImagen;

        displayCard.Add(new Card(id, valor, color, accion, spriteImagen));
        /*id = displayCard[0].id;
        spriteImagen = displayCard[0].spriteImagen;        */

        artImage.sprite = spriteImagen;
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}