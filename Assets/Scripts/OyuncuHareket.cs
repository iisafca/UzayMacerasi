using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuHareket : MonoBehaviour
{
    Rigidbody2D rb2d;
    Animator animator;

    Vector2 velocity;

    [SerializeField]
    float hiz = default;
    [SerializeField]
    float hizlanma = default;
    [SerializeField]
    float yavaslama = default;
    [SerializeField]
    float ziplamaGucu = default;
    [SerializeField]
    int ziplamaLimiti = 3;

    int ziplamaSayisi;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        KlavyeKontrol();
    }

    void KlavyeKontrol()
    {
        float hareketInput = Input.GetAxisRaw("Horizontal");
        Vector2 scale = transform.localScale;

        if (hareketInput > 0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, hareketInput * hiz, hizlanma * Time.deltaTime);
            animator.SetBool("Walk", true);
            scale.x = 0.3f;
        }
        else if (hareketInput<0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, hareketInput * hiz, hizlanma * Time.deltaTime);
            animator.SetBool("Walk", true);
            scale.x = -0.3f;
        }
        else
        {
            velocity.x = Mathf.MoveTowards(velocity.x, 0, yavaslama * Time.deltaTime);
            animator.SetBool("Walk", false);
        }

        transform.localScale = scale;
        transform.Translate(velocity * Time.deltaTime);

        if (Input.GetKeyDown("space"))
        {
            ZiplamayiBaslat();
        }
        if (Input.GetKeyUp("space"))
        {
            ZiplamayiDurdur();
        }
    }
    
    void ZiplamayiBaslat()
    {
        if (ziplamaSayisi<ziplamaLimiti)
        {
            rb2d.AddForce(new Vector2(0, ziplamaGucu), ForceMode2D.Impulse);
            animator.SetBool("Jump", true);
        }
        
    }

    void ZiplamayiDurdur()
    {
        animator.SetBool("Jump", false);
        ziplamaSayisi++;
    }

    public void ZiplamayiSifirla()
    {
        ziplamaSayisi = 0;
        Debug.Log("Ziplama sýfýrlandý");
    }
}
