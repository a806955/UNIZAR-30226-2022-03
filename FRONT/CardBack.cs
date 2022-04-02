using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//La parte de atras de la carta
public class CardBack : MonoBehaviour
{
    public GameObject cardBack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DisplayCard.staticCardBack == true){
            cardBack.SetActive(true);
        } else{
            cardBack.SetActive(false);
        }
    }
}
