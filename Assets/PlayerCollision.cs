﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour{

    private void OnTriggerEnter(Collider other){
        Debug.Log("collison found");
        Application.LoadLevel(Application.loadedLevel);
    }
}