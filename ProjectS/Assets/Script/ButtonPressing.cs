using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressing : MonoBehaviour
{
    private SpriteRenderer DeezSp;
    public Sprite DefaultSp;
    public Sprite PressSp;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Yeet");
        if (collision.CompareTag("UpNote")) 
        {
            Debug.Log("XD");
            if (Input.GetKeyDown(KeyCode.W))
            {
                DeezSp.sprite = PressSp;
                Debug.Log("Yeet");
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                DeezSp.sprite = DefaultSp;
                Debug.Log("Yeet");
            }
        }
        if (collision.CompareTag("DownNote"))
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                DeezSp.sprite = PressSp;
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                DeezSp.sprite = DefaultSp;
            }
        }
        if (collision.CompareTag("LeftNote"))
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                DeezSp.sprite = PressSp;
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                DeezSp.sprite = DefaultSp;
            }
        }
        if (collision.CompareTag("RightNote"))
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                DeezSp.sprite = PressSp;
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                DeezSp.sprite = DefaultSp;
            }
        }
    }
}
