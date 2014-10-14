using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	public GameObject player;
	private GameCamera cam;
	
	void Start () {
		cam = GetComponent<GameCamera>();
		cam.transform.Rotate (new Vector3 (10, 0, 0));
		SpawnPlayer();
	}
	
	// Spawn player
	private void SpawnPlayer() {
		cam.SetTarget((Instantiate(player,Vector3.zero,Quaternion.identity) as GameObject).transform);
	}
}
