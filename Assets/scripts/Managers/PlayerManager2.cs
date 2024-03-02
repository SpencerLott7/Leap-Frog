using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager2 : MonoBehaviour, IGameManager {
	public ManagerStatus status {get; private set;}

	public int health {get; private set;}
	public int maxHealth {get; private set;}
	public int jumpCount {get;private set;}

	public void Startup() {
		Debug.Log("Player manager starting...");

		// these values could be initialized with saved data
		health = 5;
		maxHealth = 5;
		jumpCount = 2;

		// any long-running startup tasks go here, and set status to 'Initializing' until those tasks are complete
		status = ManagerStatus.Started;
	}

	public void ChangeHealth(int value) {
		health += value;
		if (health > maxHealth) {
			health = maxHealth;
		} else if (health < 0) {
			health = 0;
		}

		Debug.Log($"Health: {health}/{maxHealth}");
	}
	public void addJump(int value)
	{
		jumpCount += value;
	}
}