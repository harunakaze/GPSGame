﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {
    public Transform sp1;
    public Transform sp2;
    public Transform sp3;

    public GameObject m1;
    public GameObject m2;
    public GameObject m3;
    public GameObject m4;
    public GameObject m5;


    public AudioSource bgmSS;
    public AudioClip ss1;
    public AudioClip ss2;
    public AudioClip ss3;
    public AudioClip ss4;
    public AudioClip ss5;

    public int repeatrate;
    public int waved;

    int enemytotal = 0;
    int enemydie = 0;

    public int stage = 1;
    int c = 5;
	// Use this for initialization
	void Start () {
        switch(stage) {
            case 1:
                StartCoroutine(stage1());
                break;
            case 2:
                StartCoroutine(stage2());
                break;
            case 3:
                StartCoroutine(stage3());
                break;
            case 4:
                StartCoroutine(stage4());
                break;
            case 5:
                StartCoroutine(stage5());
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
        
        if (stage==2&&enemytotal==0)
        {
            StartCoroutine(stage2());
        }
        else if (stage == 3 && enemytotal == 0)
        {
            StartCoroutine(stage3());
        }
        else if (stage == 4 && enemytotal == 0)
        {
            StartCoroutine(stage4());
        }
        else if (stage == 5 && enemytotal == 0)
        {
            StartCoroutine(stage5());
        }
	}

    IEnumerator stage1()
    {
        bgmSS.clip = ss1;
        bgmSS.Play();

        enemytotal = 15;
        //15MusuhA
        yield return new WaitForSeconds(3);
        while (c>0)
        {
            CreateEnemy(m1, sp1);
            CreateEnemy(m1, sp2);
            CreateEnemy(m1, sp3);
            
            yield return new WaitForSeconds(repeatrate);
            c--;
        }
        c = 5;
        
    }

    IEnumerator stage2()
    {
        bgmSS.clip = ss2;
        bgmSS.Play();


        enemytotal = 20;
        yield return new WaitForSeconds(waved);
        //10MusuhA + 10MusuhB
        while (c > 0)
        {
            CreateEnemy(m1, sp1);
            CreateEnemy(m1, sp2);
            CreateEnemy(m2, sp2);
            CreateEnemy(m2, sp3);

            yield return new WaitForSeconds(repeatrate);
            c--;
        }
        c = 5;
    }

    IEnumerator stage3()
    {
        bgmSS.clip = ss3;
        bgmSS.Play();


        enemytotal = 25;
        yield return new WaitForSeconds(waved);
        //5MusuhA + 10MusuhB +10MusuhC
        while (c > 0)
        {
            CreateEnemy(m1, sp1);
            CreateEnemy(m2, sp2);
            CreateEnemy(m3, sp2);
            CreateEnemy(m2, sp3);
            CreateEnemy(m3, sp3);

            yield return new WaitForSeconds(repeatrate);
            c--;
        }
        c = 5;
    }

    IEnumerator stage4()
    {
        bgmSS.clip = ss4;
        bgmSS.Play();

        enemytotal = 16;
        yield return new WaitForSeconds(waved);

        while (c > 0)
        {
            CreateEnemy(m1, sp1);
            CreateEnemy(m2, sp2);
            CreateEnemy(m3, sp3);
            if (c==1)
            {
            //CreateEnemy(m4, sp1);
            //yield return new WaitForSeconds(waved);
            //CreateEnemy(m4, sp2);
            yield return new WaitForSeconds(waved);
            //CreateEnemy(m4, sp3);
            CreateEnemy(m4, sp1);
            }
            yield return new WaitForSeconds(repeatrate);
            c--;
        }
        c = 5;
    }

    IEnumerator stage5()
    {
        bgmSS.clip = ss5;
        bgmSS.Play();

        //Boss(MusuhE)
        enemytotal = 1;
        yield return new WaitForSeconds(waved);
        CreateEnemy(m5, sp2);
    }


    IEnumerator WaveDelay()
    {
        yield return new WaitForSeconds(waved);
    }
    void CreateEnemy(GameObject EnemyType, Transform SpawnLocation)
    {
        Instantiate(EnemyType, SpawnLocation.position, SpawnLocation.rotation);
        
    }

    void OnEnable()
    {
        EventManager.StartListening("Die", CheckEnemy);
    }

    void OnDisable()
    {
        EventManager.StopListening("Die", CheckEnemy);
    }

    void CheckEnemy()
    {
        enemydie++;
        if (enemytotal == enemydie)
        {
            Debug.Log("Next Stage");
            stage++;
            enemydie = 0;
            enemytotal = 0;

            bgmSS.Stop();
        }
    }
}
