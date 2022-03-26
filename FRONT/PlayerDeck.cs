using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();

    private int id;
    private int valor;
    private string color;
    private string accion;
    private Sprite sprite;

    // Cargamos de la base de datos todas cartas
    void Start()
    {
        int indexDeck = 0;

        while(indexDeck < 55){
            id = CardDatabase.cardList[indexDeck].id;
            valor = CardDatabase.cardList[indexDeck].valor;
            color = CardDatabase.cardList[indexDeck].color;
            accion = CardDatabase.cardList[indexDeck].accion;
            sprite = CardDatabase.cardList[indexDeck].spriteImagen;

            if((indexDeck == 3) || (indexDeck == 13) || (indexDeck == 27) || (indexDeck == 41)){
                //Si es una de las cartas numero 0
                //deck[indexDB] = CardDatabase.cardList[indexDeck]; indexDB++;
                deck.Add(new Card(id, valor, color, accion, sprite));
            } else{
                //Si no es una de las cartas de numero 0
                if((indexDeck == 23) || (indexDeck == 9)){
                    //Si es una carta de las que existen 4
                    deck.Add(new Card(id, valor, color, accion, sprite));
                    deck.Add(new Card(id, valor, color, accion, sprite));
                    deck.Add(new Card(id, valor, color, accion, sprite));
                    deck.Add(new Card(id, valor, color, accion, sprite));
                } else if(indexDeck != 37){
                    //Si es cualquier carta doble (37 es una carta basura)
                    deck.Add(new Card(id, valor, color, accion, sprite));
                    deck.Add(new Card(id, valor, color, accion, sprite));
                }
            }

            indexDeck++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
