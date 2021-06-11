namespace HelpLone.Interfaces
{
    //This Interface contains all properties that all heroes owns
    public interface ICharacter
    {
        void Heal();
        void Die();
        void Fight();
    }
}