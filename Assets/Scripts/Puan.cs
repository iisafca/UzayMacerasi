using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Puan : MonoBehaviour
{

    int puan;
    int altin;

    [SerializeField]
    Text puanText = default;

    [SerializeField]
    Text altinText = default;

    // Start is called before the first frame update
    void Start()
    {
        altinText.text = "x" + altin;
    }

    // Update is called once per frame
    void Update()
    {
        puan = (int)Camera.main.transform.position.y;
        puanText.text = "Puan: " + puan;
    }

    public void AltinKazan()
    {
        altin++;
        altinText.text = "x" + altin;

    }
}
