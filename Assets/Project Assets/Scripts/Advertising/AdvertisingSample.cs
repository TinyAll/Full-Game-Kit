using System;
using UnityEngine;

/// <summary>
/// Advertising sample.
/// This is a reference/sample script for implementing ads in your mobile game.
/// For our Google Play version we used Chartboost.
/// </summary>
public class AdvertisingSample: MonoBehaviour
{
	public bool forceShowInterstitial = false; // bool/toggle so we can check and force an interstitial at certain moments in the game

	public bool hasInterstitial = false; // is an interstitial cached?
	public bool hasRewardedVideo = false; // is a rewarded video cached?

	void Awake(){
		Scripts.advertising = this;
	}

	void OnEnable() {
		// Do stuff
	}
	
	void Start() {
		// Do stuff
		// E.g. Cache video/interstitials, setup delegates, whatnot...
		CacheInterstitial();
		CacheVideo();

		// Register me
		Scripts.advertising = this;
	}
	

	public void CacheInterstitial(){
		hasInterstitial = true;
	}

	public void ShowInterstitial(){
		Debug.Log("[AdvertisingSample] ShowInterstitial called");
	}

	public void CacheVideo(){
		hasRewardedVideo = true;
	}

	public void ShowVideo(){
		Debug.Log("[AdvertisingSample] ShowVideo called");
	}
}


