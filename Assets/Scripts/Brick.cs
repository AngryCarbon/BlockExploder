using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public Sprite[] damageSprites;
	public static int breakableCount = 0;
	public AudioClip blockDamageSound;

	private int timesHit;
	private LevelManager levelManager;
	private bool isBreakable;

	// Use this for initialization
	void Start () {
		timesHit = 0;
		isBreakable = (this.tag == "Breakable");
		
		if (isBreakable) {
			breakableCount++;
			Debug.Log(breakableCount);
		}
		
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter2D (Collision2D collision) {
		AudioSource.PlayClipAtPoint (blockDamageSound, transform.position);
		if (isBreakable) {
			HandleHits ();
		}
	}
	
	void HandleHits () {
		timesHit++;
		int maxHits = damageSprites.Length + 1;
		
		if (timesHit >= maxHits) {
			breakableCount--;
			levelManager.BrickDestroyed ();
			Destroy (gameObject);
		} else {
			LoadSprite ();
		}
	}
	
	void LoadSprite () {
		int spriteIndex = timesHit - 1;
		
		if (damageSprites[spriteIndex]) {
			this.GetComponent<SpriteRenderer> ().sprite = damageSprites[spriteIndex];
		} else {
			Debug.Log (this.name + ": Sprite at index " + spriteIndex + " did not load!");
		}
	}
}
