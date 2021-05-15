using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovementV1 : TankMovement
{
    [SerializeField]
    private float leftRightValue = 0f;
    private float leftRightPressedValue = 0.5f;
    private float leftRightMultiplier = 0.1f;

    private Vector3 startMidPos;

    protected Animator animator;

    //==========================================================//

    private float LeftRightPressedValue
    {
        get { return leftRightPressedValue; }
        set
        {
            leftRightPressedValue = value;
            UpdateAnimations();
        }
    }


    new void Awake()
    {
        base.Awake();
        animator = GetComponent<Animator>();
        leftRightMultiplier = StaticData.TankData.LeftRightMovementMultiplier;
    }

    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
        startMidPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void ApplyMovement(MovementKey movementKey)
    {
        //Debug.Log("MovementKey: " + movementKey.ToString());
        if (movementKey == MovementKey.LeftArrow)
        {
            if (leftRightValue > -1f)
            {
                leftRightValue -= 0.05f * leftRightMultiplier * Time.deltaTime;
            }
            else leftRightValue = -1f;

            if (LeftRightPressedValue > -1f)
            {
                LeftRightPressedValue -= leftRightMultiplier * Time.deltaTime;
            }
            else LeftRightPressedValue = -1f;
        }
        else if (movementKey == MovementKey.RightArrow)
        {
            if (leftRightValue < 1f)
            {
                leftRightValue += 0.05f * leftRightMultiplier * Time.deltaTime;
            }
            else leftRightValue = 1f;

            if (LeftRightPressedValue < 1f)
            {
                LeftRightPressedValue += leftRightMultiplier * Time.deltaTime;
            }
            else LeftRightPressedValue = 1f;
        }
        else
        {
            LeftRightPressedValue += (0 - LeftRightPressedValue) * Time.deltaTime;
        }

        UpdatePosition(
            new Vector3().Lerp(mapHandler.LeftMaxMovement.position
            , mapHandler.RightMaxMovement.position, leftRightValue)
            );
    }

    public override void UpdatePosition(Vector3 newPos)
    {
        base.UpdatePosition(newPos);
    }

    protected virtual void UpdateAnimations()
    {
        animator.SetFloat("LeftRight", LeftRightPressedValue * 0.5f + 0.5f);
    }

}
