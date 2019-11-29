using UnityEngine;
using System.Collections.Generic;
using Vuforia;

public class DontDestroy : MonoBehaviour
{

    // Use this for initialization
void Start() {
    if (VuforiaRuntime.Instance.InitializationState == VuforiaRuntime.InitState.INITIALIZED) {
        TrackerManager.Instance.GetStateManager().ReassociateTrackables();
        VuforiaBehaviour.Instance.enabled = true;
        return;
    }
}
	
	// Update is called once per frame
	void Update () {
		
	}
}
