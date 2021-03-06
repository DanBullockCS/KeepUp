﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Bounce : MonoBehaviour {
    private Rigidbody2D rb;

    AudioSource aSource;
    public AudioClip[] audioClips;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        aSource = gameObject.GetComponent<AudioSource>();
    }
    void PlayRandom() {
        // Play a Random paper ball audio clip
        if (PlayerPrefs.GetInt("MuteSound") == 0) {
            aSource.clip = audioClips[Random.Range(0, audioClips.Length)];
            aSource.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D col) {
        rb.AddTorque(0.1f);
        rb.AddForce(new Vector2(0f, 1.0f));
        PlayRandom();

        // Game Over
        if (col.gameObject.layer == LayerMask.NameToLayer("Ground")) {
            SceneManager.LoadScene("EndScreen");
        }

        if (col.gameObject.tag.Equals("Player")) {
            AddBounce();
        }
    }

    public void AddBounce() {
        BounceCount.numBounces += 1;
        // Make sure user can't sit at the edge of the screen and just bounce the ball straight up
        if (rb.position.x <= -2.4f || rb.position.x >= 2.4f) {
            rb.AddForce(new Vector2(0.1f, 0.0f));
        }
    }
}
