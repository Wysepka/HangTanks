using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankTest : Tank
{
    [SerializeField]
    GameObject upObj=null;

    [SerializeField]
    GameObject missilePrefab=null;

    [SerializeField]
    Transform shootPlace=null;

    [SerializeField]
    int iloscAmmoMax=30;

    private Quaternion desiredRotation;
    private Vector3 rotationVelocity;
    private TankStatsUI tankStatsUI;
    private int iloscAmmo;

    private void Awake()
    {
        tankStatsUI = FindObjectOfType<TankStatsUI>();
    }

    // Start is called before the first frame update
    void Start()
    {
        iloscAmmo = iloscAmmoMax;
    }

    // Update is called once per frame
    void Update()
    {
        float zOffset = Vector3.Distance(upObj.transform.position, Camera.main.transform.position);
        Vector3 mousePosOffset = new Vector3(Input.mousePosition.x, Input.mousePosition.y,zOffset);
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePosOffset);

        float upObjY = upObj.transform.position.y;
        Vector3 forwardDir = worldPos - upObj.transform.position;
        desiredRotation = Quaternion.LookRotation(forwardDir, Vector3.up);

        if (Input.GetKeyDown(KeyCode.Mouse0)) Shoot();
    }

    private void FixedUpdate()
    {
        upObj.transform.rotation = Utils.SmoothDampQuaternion(upObj.transform.rotation, desiredRotation,ref rotationVelocity, 0.5f);
    }

    private void Shoot()
    {
        if (iloscAmmo > 0)
        {

            GameObject missile = Instantiate(missilePrefab, shootPlace.position, shootPlace.rotation);
            missile.GetComponent<MissileTest>().LaunchMissile();

            iloscAmmo = iloscAmmo - 1;

            tankStatsUI.SetAmmo(iloscAmmo, iloscAmmoMax);
        }
    }
}
