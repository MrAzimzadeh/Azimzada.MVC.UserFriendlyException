namespace Azimzada.MVC.UserFriendlyException;

public class UserFriendlyException : Exception
{
    public UserFriendlyException(string message) : base(message)
    {
    }
}
