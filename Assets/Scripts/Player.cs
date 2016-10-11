using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public int id;

    public string playerName;
    public string backStory;
    public float health;
    public float damage;

    public float weapon1Damage, weapon2Damage;

    public string shoeName;
    public int shoeSize;
    public int shoeType;

	// Use this for initialization
	void Start () {
        health = 50;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
