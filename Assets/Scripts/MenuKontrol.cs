using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuKontrol : MonoBehaviour
{
    [SerializeField]
    Sprite[] muzik�konlar = default;

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
            muzikButton.image.sprite = muzik�konlar[0];
        }
        else
        {
            muzikAcik = true;
            muzikButton.image.sprite = muzik�konlar[1];
        }
    }
}
