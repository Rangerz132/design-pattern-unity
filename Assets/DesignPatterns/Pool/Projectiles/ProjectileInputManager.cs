using System.Collections.Generic;
using System;
using UnityEngine;

public class ProjectileInputManager : MonoBehaviour
{
    [Serializable]
    private class ProjectileInput
    {
        public KeyCode keyboardKey;
        public ProjectileType projectileType;
    }

    [SerializeField] private List<ProjectileInput> projectileInputs = new List<ProjectileInput>();

    void Update()
    {
        for (var i = 0; i < projectileInputs.Count; i++) {
            if (Input.GetKeyDown(projectileInputs[i].keyboardKey)) {
                ProjectilePoolManager.OnGetProjectile?.Invoke(projectileInputs[i].projectileType);
            }
        }
    }
}
