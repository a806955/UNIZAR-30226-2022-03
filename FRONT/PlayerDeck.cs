using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    //public List<Card> container = new List<Card>();


    public GameObject cartaMedio;
    public GameObject carta1J1, carta2J1, carta3J1, carta4J1;
    public GameObject boton1J1, boton2J1, boton3J1, boton4J1;
    public GameObject saltarTurno;
    public GameObject textoNoTurno, textoNoCoincide;

    //Cosas de la carta NO SON NECESARIOS PORQUE ERA PARA MEZCLAR BARAJA ETC
    /*private int id;
    private int valor;
    private string color;
    private string accion;
    private Sprite sprite;*/
    
    //Vectores auxiliares
    private DisplayCard cartaM, carta;
    private int esMiTurno = 0;
    private IEnumerator coroutine;


    // Cargamos de la base de datos todas cartas
    void Start()
    {
        

        //Aqui voy a meter un valor a la lista del container, se usa para intercambiar
        //las cartas random, no se por que crea una lista y no una sola carta...
        //container.Add(new Card());
    }

    // Update is called once per frame
    void Update()
    {

    }

    //NO ES NECESARIO, que backend use algo similar para generar la baraja
    /*void mezclarBaraja(){
        int indexDeck = 0;

        while(indexDeck < CardDatabase.cardList.Count){
            //AQUI GENERAMOS LAS CARTAS
            id = CardDatabase.cardList[indexDeck].id;
            valor = CardDatabase.cardList[indexDeck].valor;
            color = CardDatabase.cardList[indexDeck].color;
            accion = CardDatabase.cardList[indexDeck].accion;
            sprite = CardDatabase.cardList[indexDeck].spriteImagen;

            if((id == 3) || (id == 17) || (id == 31) || (id == 45)){
                //Si es una de las cartas numero 0
                deck.Add(new Card(id, valor, color, accion, sprite));
            } else{
                //Si no es una de las cartas de numero 0
                if((id == 27) || (id == 13)){
                    //Si es una carta de las que existen 4
                    deck.Add(new Card(id, valor, color, accion, sprite));
                    deck.Add(new Card(id, valor, color, accion, sprite));
                    deck.Add(new Card(id, valor, color, accion, sprite));
                    deck.Add(new Card(id, valor, color, accion, sprite));
                } else if(id != 41){
                    //Si es cualquier carta doble (41 es la parte de atras)
                    deck.Add(new Card(id, valor, color, accion, sprite));
                    deck.Add(new Card(id, valor, color, accion, sprite));
                }
            }

            indexDeck++;
        }

        //AQUI MEZCLAMOS LAS CARTAS
        int randomIndex = 0;
        Card cartaAux = new Card();
        for (int i = 0; i < 108; i++){ //Numero total de cartas
            //container[0] = deck[i];
            cartaAux = deck[i];
            randomIndex = Random.Range(i, 108);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = cartaAux;
        }
    }*/

    /************************************ Enviar cartas al centro ***************************************************/

    public void enviarC1alCentro(){ //asi para todas cartas?
        cartaM = cartaMedio.GetComponent("DisplayCard") as DisplayCard; //Necesario hacerlo en cada uno?
        carta = carta1J1.GetComponent("DisplayCard") as DisplayCard;

        comprobarTurnoYEnviar(carta1J1, boton1J1);
    }

    public void enviarC2alCentro(){ //asi para todas cartas?
        cartaM = cartaMedio.GetComponent("DisplayCard") as DisplayCard;
        carta = carta2J1.GetComponent("DisplayCard") as DisplayCard;

        comprobarTurnoYEnviar(carta2J1, boton2J1);
    }

    public void enviarC3alCentro(){ //asi para todas cartas?
        cartaM = cartaMedio.GetComponent("DisplayCard") as DisplayCard;
        carta = carta3J1.GetComponent("DisplayCard") as DisplayCard;

        comprobarTurnoYEnviar(carta3J1, boton3J1);
    }

    public void enviarC4alCentro(){ //asi para todas cartas?
        cartaM = cartaMedio.GetComponent("DisplayCard") as DisplayCard;
        carta = carta4J1.GetComponent("DisplayCard") as DisplayCard;

        comprobarTurnoYEnviar(carta4J1, boton4J1);
    }


    /************************************ Funciones auxiliares ***************************************************/

    private void comprobarTurnoYEnviar(GameObject cartaObject, GameObject botonObject){
        if (esMiTurno == 1){
            if ((cartaM.valor == carta.valor) || (cartaM.color == carta.color) || !(cartaMedio.activeSelf)){
                //Si son el mismo numero, si son del mismo color o si no se ha introducido ninguna carta aun
                carta.mover = 1; //Mover la carta al centro
                coroutine = EsperarACarta(cartaObject, botonObject);
                StartCoroutine(coroutine);
            } else{
                //Si no se puede poner
                textoNoCoincide.SetActive(true);
                coroutine = MsgError(textoNoCoincide);
                StartCoroutine(coroutine);
                Debug.Log("CAGASTEEEEEEE");
            }
        } else{
            textoNoTurno.SetActive(true);
            coroutine = MsgError(textoNoTurno);
            StartCoroutine(coroutine);
            Debug.Log("NO ES TU TURNO PANITA");
        }
    }

    IEnumerator EsperarACarta(GameObject cartaObject, GameObject botonObject){
        yield return new WaitForSeconds(2);

        //Que la carta del medio se quede con sus valores
        cartaM.id = carta.id;
        cartaM.valor = carta.valor;
        cartaM.color = carta.color;
        cartaM.accion = carta.accion;
        cartaM.spriteImagen = carta.spriteImagen;

        //Si la carta del medio estaba quitada, se activa
        if(!(cartaMedio.activeSelf)) cartaMedio.SetActive(true); 

        //Hacer invisible la carta y el boton
        cartaObject.SetActive(false);
        botonObject.SetActive(false);

        //Le decimos que no se mueva mas
        carta.mover = 0;
    }

    IEnumerator MsgError(GameObject texto){
        yield return new WaitForSeconds(2);
        texto.SetActive(false);
    }
}
