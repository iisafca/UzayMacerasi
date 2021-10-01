using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuKontrol : MonoBehaviour
{
    [SerializeField]
    Sprite[] muzikýkonlar = default;

    [SerializeField]
    Button muzikButton = default;

    bool muzikAcik = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OyunuBaslat()
    {
        SceneManager.LoadScene("Oyun");
    }

    public void EnYuksekPuan()
    {
        SceneManager.LoadScene("Puan");
    }

    public void Ayarlar()
    {
        SceneManager.LoadScene("Ayarlar");
    }

    public void Muzik()
    {
        if (muzikAcik)
        {
            muzikAcik = false;
            muzikButton.image.sprite = muzikýkonlar[0];
        }
        else
        {
            muzikAcik = true;
            muzikButton.image.sprite = muzikýkonlar[1];
        }
    }
}
