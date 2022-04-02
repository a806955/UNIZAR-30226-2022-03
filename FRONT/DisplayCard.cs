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

    public bool cardBack;
    public static bool staticCardBack;

    public Image artImage;

    public Transform target;
    private Vector2 position;
    private Vector2 initialPosition;
    public int mover = 0; //Forma de hacer que se mueva?

    // Start is called before the first frame update
    void Start()
    {

        id = CardDatabase.cardList[displayId].id;
        valor = CardDatabase.cardList[displayId].valor;
        color = CardDatabase.cardList[displayId].color;
        accion = CardDatabase.cardList[displayId].accion;
        spriteImagen = CardDatabase.cardList[displayId].spriteImagen;

        displayCard.Add(new Card(id, valor, color, accion, spriteImagen));

        artImage.sprite = spriteImagen;
        position = gameObject.transform.position;
        initialPosition = position;
    }

    // Update is called once per frame
    void Update()
    {
        artImage.sprite = spriteImagen;
        staticCardBack = cardBack;

        //Para que se mueva
        float step = Time.deltaTime * 250; //valor por los jajas

        if(mover == 1){
            transform.position = Vector2.MoveTowards(transform.position, target.position, step);
        }
    }
}