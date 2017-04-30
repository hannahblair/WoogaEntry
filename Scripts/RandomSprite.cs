using UnityEngine;
using System.Collections;

public class RandomSprite : MonoBehaviour {

    public Sprite[] sprites;
    public int CurrentSprite = -1;

	// Use this for initialization
	void Start () {

        if(CurrentSprite == -1)
        {
            CurrentSprite = Random.Range(0, sprites.Length);
        } else if (CurrentSprite > sprites.Length)
        {
            CurrentSprite = sprites.Length - 1;
        }
        GetComponent<SpriteRenderer>().sprite = sprites[CurrentSprite];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
