using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int items = 0;
    [SerializeField] private Text itemsText;
    private bool HaveKey;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HaveKey = false;
        if (collision.gameObject.CompareTag("collectable"))
        {
            Destroy(collision.gameObject);
            items++;
            itemsText.text = "Score: " + (items*10);
        }
        if (collision.gameObject.CompareTag("Key"))
        {
            Destroy(collision.gameObject);
            items++;
            itemsText.text = "Score: " + (items * 1000);
            HaveKey = true;
        }
    }
}
