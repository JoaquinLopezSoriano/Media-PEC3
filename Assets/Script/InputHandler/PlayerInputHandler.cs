using UnityEngine;
using UnityEngine.InputSystem;

namespace Script.InputHandler
{
    public class PlayerInputHandler : MonoBehaviour
    {
        protected PlayerInput m_playerInput;
        protected InputAction m_Move;
        protected InputAction m_Attack;
        protected InputAction m_Defense;
        protected InputAction m_Exit;

        protected void Awake()
        {
            m_playerInput = new PlayerInput();
            m_playerInput.Enable();
        }

        protected void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        
        public Vector2 GetMoveInput()
        {
            return m_Move.ReadValue<Vector2>();
        }

    
        public bool GetAttackInputPressed()
        {
            return m_Attack.triggered;
        }
        
        public bool GetDefensenputPressed()
        {
            return m_Defense.triggered;
        }
        
        public bool GetExitPressed()
        {
            return m_Exit.triggered;
        }
    }
    
}
