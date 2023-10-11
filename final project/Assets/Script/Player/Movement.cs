using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Script.Player
{
    public class Movement : MonoBehaviour
    {
        // Player Components
        private PlayerControl _playerInput;
        private CharacterController _controller;
        private Animator _playerAnimator;
        
        // Hash for Annimation
        private static readonly int IsWalkingHash = Animator.StringToHash("isWalking");
        private static readonly int IsRunningHash = Animator.StringToHash("isRunning");
        private static readonly int IsJumpingHash = Animator.StringToHash("isJumping");
        private static readonly int BdayDanceHash = Animator.StringToHash("BdayDance");
        private static readonly int SillyDanceHash = Animator.StringToHash("SillyDance");
        private static readonly int RobotDanceHash = Animator.StringToHash("RobotDance");
        private static readonly int BUpDanceHash = Animator.StringToHash("BUpDance");
        
        // variables to store player input
        private Vector2 _currentMovement;
        private Vector3 _currentMovementInput;
        private bool _movementPressed;
        private bool _runPressed;
        private bool jumpPressed;
        private Vector3 velocity;
        private float mass = 45;

        // Player
        [SerializeField] private float playerSpeed = 5;
        [SerializeField] private float rotationFactorPerFrame = 15.0f;
        [SerializeField]private float gravity = -9.81f;
        
        [Header("Player Grounded")]
        [Tooltip("If the character is grounded or not. Not part of the CharacterController built in grounded check")]
        public bool Grounded = true;
        [Tooltip("Ground Check of the Player")]
        public Transform groundCheckObject;
        [Tooltip("Useful for rough ground")]
        public float GroundedOffset = -0.14f;
        [Tooltip("The radius of the grounded check. Should match the radius of the CharacterController")]
        public float GroundedRadius = 0.28f;
        [Tooltip("What layers the character uses as ground")]
        public LayerMask GroundLayers;

        // Unity Functions
        private void Awake()
        {
            _playerInput = new PlayerControl();
            _controller = GetComponent<CharacterController>();
            _playerAnimator = GetComponent<Animator>();

            _playerInput.Player.Movement.started += ONMovementInput;
            _playerInput.Player.Movement.canceled += ONMovementInput;
            _playerInput.Player.Movement.performed += ONMovementInput;
            _playerInput.Player.Run.performed += RunOnperformed;
            _playerInput.Player.Run.canceled += RunOnperformed;
            _playerInput.Player.Jump.performed += JumpOnperformed;
            _playerInput.Player.Jump.canceled += JumpOnperformed;
            _playerInput.Dance.BDayDance.started += BdayDance;
            _playerInput.Dance.BDayDance.performed += BdayDance;
            _playerInput.Dance.BDayDance.canceled += BdayDance;
            _playerInput.Dance.SillyDance.started += SillyDance;
            _playerInput.Dance.SillyDance.performed += SillyDance;
            _playerInput.Dance.SillyDance.canceled += SillyDance;
            _playerInput.Dance.RobotDance.started += RobotDance;
            _playerInput.Dance.RobotDance.performed += RobotDance;
            _playerInput.Dance.RobotDance.canceled += RobotDance;
            _playerInput.Dance.BUpDance.started += BUpDance;
            _playerInput.Dance.BUpDance.performed += BUpDance;
            _playerInput.Dance.BUpDance.canceled += BUpDance;
        }
        void Start()
        {
            _playerAnimator = GetComponent<Animator>();
        }
        private void Update()
        {
            HandleRotation();
            Walk();
            Run();
            Jump();
            GroundedCheck();
            _controller.Move(_currentMovementInput * playerSpeed * Time.deltaTime);
        }
        
        // Input Lamda Functions
        private void ONMovementInput(InputAction.CallbackContext context)
        {
            _currentMovement = context.ReadValue<Vector2>();
            _currentMovementInput.x = _currentMovement.x;
            _currentMovementInput.z = _currentMovement.y; 
            _movementPressed = _currentMovement.x != 0 || _currentMovement.y != 0;
        }
        private void RunOnperformed(InputAction.CallbackContext context){ _runPressed = context.ReadValueAsButton(); }
        private void JumpOnperformed(InputAction.CallbackContext obj){ jumpPressed = obj.ReadValueAsButton(); }
        
        //Handle Animation and Rotation
        private void HandleRotation()
        {
            Vector3 positionToLookAt;
            positionToLookAt.x = _currentMovementInput.x;
            positionToLookAt.y = 0.0f;
            positionToLookAt.z = _currentMovementInput.z;

            Quaternion currentRotation = transform.rotation;

            if (_movementPressed)
            {
                Quaternion targetRotation = Quaternion.LookRotation(positionToLookAt);
                transform.rotation = Quaternion.Slerp(currentRotation, targetRotation, rotationFactorPerFrame * Time.deltaTime);                
            }
        }
        private void Walk()
        {
            bool isWalking = _playerAnimator.GetBool(IsWalkingHash);
            if (_movementPressed && !isWalking){ _playerAnimator.SetBool(IsWalkingHash, true); }
            if (!_movementPressed && isWalking) { _playerAnimator.SetBool(IsWalkingHash, false); }
        }
        private void Run()
        {
            bool isRunning = _playerAnimator.GetBool(IsRunningHash);
            if ((_movementPressed && _runPressed) && !isRunning){ _playerAnimator.SetBool(IsRunningHash, true); }
            if(!(_movementPressed && _runPressed) && isRunning){ _playerAnimator.SetBool(IsRunningHash, false);}
        }
        private void Jump()
        {
            bool isJumping = _playerAnimator.GetBool(IsJumpingHash);
            if (!isJumping && jumpPressed) { _playerAnimator.SetBool(IsJumpingHash, true); }
            if(isJumping && !jumpPressed) { _playerAnimator.SetBool(IsJumpingHash, false);}
        }
        private void GroundedCheck()
        {
            // set sphere position, with offset
            // Vector3 spherePosition = new Vector3(transform.position.x, transform.position.y - GroundedOffset, transform.position.z);
            Grounded = Physics.CheckSphere(groundCheckObject.transform.position, GroundedRadius, GroundLayers, QueryTriggerInteraction.Ignore);

            // update animator if using character
            if (Grounded && velocity.y < 0)
                velocity.y = -2f;
            if (Grounded)
            {
                _playerAnimator.SetBool(IsWalkingHash, Grounded);
            }

            velocity.y += mass * gravity * Time.deltaTime; 
        }
        
        // Dance
        private void BdayDance(InputAction.CallbackContext context)
        {
            Debug.Log("Dance");
            bool isDancing = _playerAnimator.GetBool(BdayDanceHash);
            if(!isDancing && context.performed){ _playerAnimator.SetBool(BdayDanceHash, true);}
            if(isDancing && context.canceled){ _playerAnimator.SetBool(BdayDanceHash, false);}
        }

        private void SillyDance(InputAction.CallbackContext context)
        {
            bool isDancing = _playerAnimator.GetBool(SillyDanceHash);
            if(!isDancing && context.performed){ _playerAnimator.SetBool(SillyDanceHash, true);}
            if(isDancing && context.canceled){ _playerAnimator.SetBool(SillyDanceHash, false);}
        }

        private void RobotDance(InputAction.CallbackContext context)
        {
            bool isDancing = _playerAnimator.GetBool(RobotDanceHash);
            if(!isDancing && context.performed){ _playerAnimator.SetBool(RobotDanceHash, true);}
            if(isDancing && context.canceled){ _playerAnimator.SetBool(RobotDanceHash, false);}
        }

        private void BUpDance(InputAction.CallbackContext context)
        {
            bool isDancing = _playerAnimator.GetBool(BUpDanceHash);
            if(!isDancing && context.performed){ _playerAnimator.SetBool(BUpDanceHash, true);}
            if(isDancing && context.canceled){ _playerAnimator.SetBool(BUpDanceHash, false);}
        }
        
        // Enable / Disable
        private void OnEnable()
        {
            _playerInput.Enable();
            // _playerInput.Dance.Enable();
        }
        private void OnDisable()
        {
            _playerInput.Disable();
            // _playerInput.Dance.Disable();
        }
    }
}