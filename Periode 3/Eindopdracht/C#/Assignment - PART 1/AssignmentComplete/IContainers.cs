using Microsoft.Xna.Framework;

namespace AssignmentComplete
{
    public interface IContainers
    {
        int getCurrentAmount { get; }
        Vector2 getPosition { get; }
        void setPosition();

    }
}