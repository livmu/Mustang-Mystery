using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{

    /*public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeSprite(newSprite);
        }
    }*/
    public Image image;

    void Start()
    {
        image.enabled = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            image.enabled = true;
        }
    }
}
