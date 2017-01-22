using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AturPrologue : MonoBehaviour
{

    //public GameObject splash;
    public GameObject menu;
    public Animator animator;
    public MenuStuff ms;

    [Header("Paragraph")]
    public GameObject par1;
    public GameObject par2;
    public GameObject par3;
    //public GameObject par4;
    //public GameObject par5;

    [Header("Deburan Ombak")]
    public AudioSource sumber;
    public AudioClip debur1;
    public AudioClip debur2;
    public AudioClip debur3;
    public AudioClip debur4;
    //public AudioClip debur5;
    //public AudioClip debur6;

    float x = 0;

    // Use this for initialization
    void Start()
    {
        menu.SetActive(false);
        //splash.SetActive(true);

        par1.SetActive(true);
        par2.SetActive(false);
        par3.SetActive(false);
        //par4.SetActive(false);
        //par5.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(lanjut());
        Debug.Log(x);
        /*
        if (x == 1)
        {
            splash.SetActive(false);
            par1.SetActive(true);
            //sumber.PlayOneShot(debur1);
        }
        else if (x == 2)
        {
            par1.SetActive(false);
            par2.SetActive(true);
        }
        else if (x == 3)
        {
            par2.SetActive(false);
            par3.SetActive(true);
        }
        else if (x == 4)
        {
            par3.SetActive(false);
            par4.SetActive(true);
        }
        else if (x == 5)
        {
            par4.SetActive(false);
            par5.SetActive(true);
        }
        else if (x == 6)
        {
            par5.SetActive(false);
            menu.SetActive(true);
        }*/
    }

    IEnumerator lanjut()
    {
        yield return new WaitForSeconds(1);
        if (Input.GetButtonUp("Jump") ||Input.GetButtonUp("Fire1") || Input.GetButtonUp("Submit"))
        {
            //par1.SetActive(true);
            x = x + 1;

            if (x == 1)
            {
                sumber.PlayOneShot(debur1);
                //splash.SetActive(false);
                par1.SetActive(false);
                par2.SetActive(true);
            }
            if (x == 2)
            {
                sumber.PlayOneShot(debur2);
                par2.SetActive(false);
                par3.SetActive(true);
            }
            if (x == 3)
            {
                sumber.PlayOneShot(debur3);
                menu.SetActive(true);
                par3.SetActive(false);
                animator.SetTrigger("Run");
                ms.isRunning = true;
                //menu.SetActive(true);
            }
            /*         if (x == 4)
                     {
                         sumber.PlayOneShot(debur4);
                         par3.SetActive(false);
                         menu.SetActive(true);
                     }
                     if (x == 5)
                     {
                         sumber.PlayOneShot(debur5);
                         par4.SetActive(false);
                         par5.SetActive(true);
                     }
                     if (x == 6)
                     {
                         sumber.PlayOneShot(debur6);
                         par5.SetActive(false);
                         menu.SetActive(true);
                     } */

        }
    }

}
