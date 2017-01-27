using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts
{
    public class AutoFire : MonoBehaviour
    {
        public float Delay;
        public Weapon[] Weapons;

        [HideInInspector]
        [SerializeField] private float _timeRemaining;

        public void Awake()
        {
            _timeRemaining = Delay;
        }

        public void Update()
        {
            _timeRemaining -= Time.deltaTime;
            if (_timeRemaining > 0)
                return;
            Weapons.ToList().ForEach(x => x.Attack());
            _timeRemaining = Delay;
        }
    }
}
