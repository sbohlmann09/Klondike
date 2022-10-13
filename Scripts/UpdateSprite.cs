using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class UpdateSprite : MonoBehaviour
{
    public Sprite cardFace;
    public Sprite cardBack;
    public Sprite newSprite;
    public GameObject cardPrefab;
    public GameObject deckButton;

    private SpriteRenderer spriteRenderer;
    private Selectable selectable;
    private Solitaire solitaire;
    private UserInput userInput;


    // Start is called before the first frame update
    void Start()
    {
        List<string> deck = Solitaire.GenerateDeck();
        solitaire = FindObjectOfType<Solitaire>();
        userInput = FindObjectOfType<UserInput>();

        int i = 0;
        foreach (string card in deck)
        {
            if(this.name == card){
                cardFace = solitaire.cardFaces[i];
                break;
            }
            i++;
        }

        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        selectable = GetComponent<Selectable>();
        // cardBack = newSprite;
    }

    // Update is called once per frame
    void Update()
    {
        deckButton.GetComponent<SpriteRenderer>().sprite = newSprite;
        if(selectable.faceUp == true){
            spriteRenderer.sprite = cardFace;

        }
        else{
            // ChangeSprite();
            spriteRenderer.sprite = newSprite;
        }

        if(userInput.slot1){

        if(name == userInput.slot1.name){
            spriteRenderer.color = Color.yellow;
        }
        else{
            spriteRenderer.color = Color.white;            
        }
        }
        
    }

    public void SetBack(Sprite s){
        // cardPrefab.GetComponent<SpriteRenderer>().sprite = s;
        cardBack = s;
        // print(solitaire.deckButton.GetComponent<SpriteRenderer>().sprite.name);
        // print(cardBack.name);
        // solitaire.deckButton.GetComponent<SpriteRenderer>().sprite = cardBack;
        // print(solitaire.deckButton.GetComponent<SpriteRenderer>().sprite.name);
        // print(solitaire.deckButton.GetComponent<SpriteRenderer>().sprite.name);
        newSprite = s;
    }
    // void ChangeSprite()
    // {
    //     spriteRenderer.sprite = newSprite; 
    // }
}
