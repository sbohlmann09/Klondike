using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckChange : MonoBehaviour
{
    public GameObject deckButton;
    public Sprite newSprite;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSprite(){
        deckButton.GetComponent<SpriteRenderer>().sprite = newSprite;
    }


}
