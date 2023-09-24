namespace Api.Exceptions
{
    public class NotFoundException: Exception
    {
        public string? Model { get; set; }

        public override string Message => $"{Model} not found";
    }
    
    public class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException()
        {
            Model = "User";
        }
        
    }
    public class PostNotFoundException : NotFoundException
    {
        public PostNotFoundException()
        {
            Model = "Post";
        }

    }

}
