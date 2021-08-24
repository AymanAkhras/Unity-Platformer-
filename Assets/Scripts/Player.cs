using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;
	public HealthBar healthBar;
	public Rigidbody2D EnemyRigidBody;
	private bool Collided = false;

    // Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.R))
		{
			
			SceneManager.LoadScene("First_Level");		}
		if (Collided == false){
			Debug.Log("Is not in contact!");
		}
	}
   
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Enemy") {
			{
				TakeDamage(20);
				Debug.Log("It is in Contact");
				Collided = true;
			}
					
		}
	}
	
	void TakeDamage(int damage)
	{
		currentHealth -= damage;
		healthBar.SetHealth(currentHealth);
	}
}
