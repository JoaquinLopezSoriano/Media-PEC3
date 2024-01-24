
namespace Script.InputHandler
{
    public class Player1InputHandler : PlayerInputHandler
    {
        private new void Awake()
        {
            base.Awake();
            m_Move = m_playerInput.Player1.Move;
            m_Attack = m_playerInput.Player1.Attack;
            m_Defense = m_playerInput.Player1.Defense;
            m_Pause = m_playerInput.Player1.Pause;
        }

    }
}
