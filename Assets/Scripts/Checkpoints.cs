﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    public Sprite redflag;
    public Sprite greenflag;
    private SpriteRenderer checkpoint;
    public bool checkpointreached;
    // Start is called before the first frame update
    void Start()
    {
        checkpoint = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Sounds.Playmusic("PlayerHit");
            checkpoint.sprite = greenflag;
            checkpointreached = true;
        }
    }
}