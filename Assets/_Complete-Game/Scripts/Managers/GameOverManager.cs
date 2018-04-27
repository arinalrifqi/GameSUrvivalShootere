using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace CompleteProject
{ 
    public class GameOverManager : MonoBehaviour
    {
        public PlayerHealth playerHealth;       // Reference to the player's health.
		//public ScoreManager scoreManager;
		public PlayerMovement playerMovement;                              // Reference to the player's movement.
		public PlayerShooting playerShooting;                              // Reference to the PlayerShooting script.
		public Animator winButton;




        Animator anim;                          // Reference to the animator component.


        void Awake ()
        {
            // Set up the reference.
            anim = GetComponent <Animator> ();
			DontDestroyOnLoad (this.gameObject);

        }


        void Update ()
        {
            // If the player has run out of health...
            if(playerHealth.currentHealth <= 0)
            {
                // ... tell the animator the game is over.
                anim.SetTrigger ("GameOver");
            }

			if (ScoreManager.score >= 20) 
			{
				//anim.SetTrigger ("WinGame");
				winButton.SetTrigger ("WinButton");
				endGame();
			}
        }


		public void endGame()
		{
			//someScript = GameObject.FindGameObjectWithTag("PlayerAnimation").GetComponent&lt;MyAnimationScript&gt;();
			playerHealth.enabled = false;
			//playerShooting.DisableEffects ();
			playerShooting.enabled = false;
			playerMovement.enabled = false;	
			//Application.LoadLevel (Application.loadedLevel);
			//SceneManager.LoadScene (nextscenes);
		}


    }
}