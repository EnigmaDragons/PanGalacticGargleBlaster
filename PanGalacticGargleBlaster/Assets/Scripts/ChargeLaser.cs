using System;
using System.Collections;
using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts
{
    public class ChargeLaser : Weapon
    {
        public LineRenderer LaserGraphics;
        public CapsuleCollider LaserHitBox;
        public float Size;
        public float ChargeTime;
        public float Duration; 

        public void Awake()
        {
            LaserHitBox.radius = Size / 2;
            PowerDown();
        }

        public void OnTriggerEnter(Collider other)
        {

        }

        public override void Attack()
        {
            StartCoroutine(FireLaser());
        }

        private IEnumerator FireLaser()
        {
            LaserGraphics.enabled = true;
            yield return new WaitForSeconds(ChargeTime * 0.25f);
            LaserGraphics.SetWidth(Size / 8, Size / 8);
            yield return new WaitForSeconds(ChargeTime * 0.25f);
            LaserGraphics.SetWidth(Size / 6, Size / 6);
            yield return new WaitForSeconds(ChargeTime * 0.25f);
            LaserGraphics.SetWidth(Size / 4, Size / 4);
            yield return new WaitForSeconds(ChargeTime * 0.25f);
            LaserGraphics.SetWidth(Size, Size);
            LaserHitBox.enabled = true;
            yield return new WaitForSeconds(Duration);
            PowerDown();
        }

        private void PowerDown()
        {
            LaserGraphics.enabled = false;
            LaserHitBox.enabled = false;
            LaserGraphics.SetWidth(Size / 10, Size / 10);
        }
    }
}
