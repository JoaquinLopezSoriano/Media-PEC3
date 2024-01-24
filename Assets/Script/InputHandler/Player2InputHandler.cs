
namespace Script.InputHandler
{
    public class Player2InputHandler : PlayerInputHandler
    {
        private new void Awake()
        {
            base.Awake();
            m_Move = m_playerInput.Player2.Move;
            m_Attack = m_playerInput.Player2.Attack;
            m_Defense = m_playerInput.Player2.Defense;
            m_Exit = m_playerInput.Player2.Exit;
        }
        
    }
}
