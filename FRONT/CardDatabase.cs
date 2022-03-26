using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {   
        /************************************* ROJAS ******************************************/
        cardList.Add(new Card(0,-1,"Rojo","Intermision",Load("spritesheet_uno", "spritesheet_uno_0")));
        cardList.Add(new Card(1,-1,"Rojo","Retorno",Load("spritesheet_uno", "spritesheet_uno_1")));
        cardList.Add(new Card(2,-1,"Rojo","Toma dos",Load("spritesheet_uno", "spritesheet_uno_2")));
        
        cardList.Add(new Card(3,0,"Rojo","nada",Load("spritesheet_uno", "spritesheet_uno_3")));
        cardList.Add(new Card(4,1,"Rojo","nada",Load("spritesheet_uno", "spritesheet_uno_4")));
        cardList.Add(new Card(5,2,"Rojo","nada",Load("spritesheet_uno", "spritesheet_uno_5")));
        cardList.Add(new Card(6,3,"Rojo","nada",Load("spritesheet_uno", "spritesheet_uno_6")));
        cardList.Add(new Card(7,4,"Rojo","nada",Load("spritesheet_uno", "spritesheet_uno_7")));
        cardList.Add(new Card(8,5,"Rojo","nada",Load("spritesheet_uno", "spritesheet_uno_8")));
        cardList.Add(new Card(9,6,"Rojo","nada",Load("spritesheet_uno", "spritesheet_uno_9")));
        cardList.Add(new Card(10,7,"Rojo","nada",Load("spritesheet_uno", "spritesheet_uno_10")));
        cardList.Add(new Card(11,8,"Rojo","nada",Load("spritesheet_uno", "spritesheet_uno_11")));
        cardList.Add(new Card(12,9,"Rojo","nada",Load("spritesheet_uno", "spritesheet_uno_12")));

        /**************************************************************************************/
        cardList.Add(new Card(13,-1,"Elige Color","Elige Color",Load("spritesheet_uno", "spritesheet_uno_13")));
        
        /********************************** AMARILLAS ******************************************/
        cardList.Add(new Card(14,-1,"Amarillo","Intermision",Load("spritesheet_uno", "spritesheet_uno_14")));
        cardList.Add(new Card(15,-1,"Amarillo","Retorno",Load("spritesheet_uno", "spritesheet_uno_15")));
        cardList.Add(new Card(16,-1,"Amarillo","Toma dos",Load("spritesheet_uno", "spritesheet_uno_16")));

        cardList.Add(new Card(17,0,"Amarillo","nada",Load("spritesheet_uno", "spritesheet_uno_17")));
        cardList.Add(new Card(18,1,"Amarillo","nada",Load("spritesheet_uno", "spritesheet_uno_18")));
        cardList.Add(new Card(19,2,"Amarillo","nada",Load("spritesheet_uno", "spritesheet_uno_19")));
        cardList.Add(new Card(20,3,"Amarillo","nada",Load("spritesheet_uno", "spritesheet_uno_20")));
        cardList.Add(new Card(21,4,"Amarillo","nada",Load("spritesheet_uno", "spritesheet_uno_21")));
        cardList.Add(new Card(22,5,"Amarillo","nada",Load("spritesheet_uno", "spritesheet_uno_22")));
        cardList.Add(new Card(23,6,"Amarillo","nada",Load("spritesheet_uno", "spritesheet_uno_23")));
        cardList.Add(new Card(24,7,"Amarillo","nada",Load("spritesheet_uno", "spritesheet_uno_24")));
        cardList.Add(new Card(25,8,"Amarillo","nada",Load("spritesheet_uno", "spritesheet_uno_25")));
        cardList.Add(new Card(26,9,"Amarillo","nada",Load("spritesheet_uno", "spritesheet_uno_26")));

        /**************************************************************************************/
        cardList.Add(new Card(27,-1,"4 colores","4 colores",Load("spritesheet_uno", "spritesheet_uno_27")));
        
        /********************************** VERDES ********************************************/
        cardList.Add(new Card(28,-1,"Verde","Intermision",Load("spritesheet_uno", "spritesheet_uno_28")));
        cardList.Add(new Card(29,-1,"Verde","Retorno",Load("spritesheet_uno", "spritesheet_uno_29")));
        cardList.Add(new Card(30,-1,"Verde","Toma dos",Load("spritesheet_uno", "spritesheet_uno_30")));

        cardList.Add(new Card(31,0,"Verde","nada",Load("spritesheet_uno", "spritesheet_uno_31")));
        cardList.Add(new Card(32,1,"Verde","nada",Load("spritesheet_uno", "spritesheet_uno_32")));
        cardList.Add(new Card(33,2,"Verde","nada",Load("spritesheet_uno", "spritesheet_uno_33")));
        cardList.Add(new Card(34,3,"Verde","nada",Load("spritesheet_uno", "spritesheet_uno_34")));
        cardList.Add(new Card(35,4,"Verde","nada",Load("spritesheet_uno", "spritesheet_uno_35")));
        cardList.Add(new Card(36,5,"Verde","nada",Load("spritesheet_uno", "spritesheet_uno_36")));
        cardList.Add(new Card(37,6,"Verde","nada",Load("spritesheet_uno", "spritesheet_uno_37")));
        cardList.Add(new Card(38,7,"Verde","nada",Load("spritesheet_uno", "spritesheet_uno_38")));
        cardList.Add(new Card(39,8,"Verde","nada",Load("spritesheet_uno", "spritesheet_uno_39")));
        cardList.Add(new Card(40,9,"Verde","nada",Load("spritesheet_uno", "spritesheet_uno_40")));

        /**************************************************************************************/
        cardList.Add(new Card(41,-1,"Parte de atras","nada",Load("spritesheet_uno", "spritesheet_uno_41")));

        /********************************** AZULES ********************************************/
        cardList.Add(new Card(42,-1,"Azul","Intermision",Load("spritesheet_uno", "spritesheet_uno_42")));
        cardList.Add(new Card(43,-1,"Azul","Retorno",Load("spritesheet_uno", "spritesheet_uno_43")));
        cardList.Add(new Card(44,-1,"Azul","Toma dos",Load("spritesheet_uno", "spritesheet_uno_44")));

        cardList.Add(new Card(45,0,"Azul","nada",Load("spritesheet_uno", "spritesheet_uno_45")));
        cardList.Add(new Card(46,1,"Azul","nada",Load("spritesheet_uno", "spritesheet_uno_46")));
        cardList.Add(new Card(47,2,"Azul","nada",Load("spritesheet_uno", "spritesheet_uno_47")));
        cardList.Add(new Card(48,3,"Azul","nada",Load("spritesheet_uno", "spritesheet_uno_48")));
        cardList.Add(new Card(49,4,"Azul","nada",Load("spritesheet_uno", "spritesheet_uno_49")));
        cardList.Add(new Card(50,5,"Azul","nada",Load("spritesheet_uno", "spritesheet_uno_50")));
        cardList.Add(new Card(51,6,"Azul","nada",Load("spritesheet_uno", "spritesheet_uno_51")));
        cardList.Add(new Card(52,7,"Azul","nada",Load("spritesheet_uno", "spritesheet_uno_52")));
        cardList.Add(new Card(53,8,"Azul","nada",Load("spritesheet_uno", "spritesheet_uno_53")));
        cardList.Add(new Card(54,9,"Azul","nada",Load("spritesheet_uno", "spritesheet_uno_54")));
    }

    Sprite Load( string imageName, string spriteName)
    {
        Sprite[] all = Resources.LoadAll<Sprite>( imageName);
 
        foreach( var s in all)
        {
            if (s.name == spriteName)
            {
                return s;
            }
        }
        return null;
    }
}
