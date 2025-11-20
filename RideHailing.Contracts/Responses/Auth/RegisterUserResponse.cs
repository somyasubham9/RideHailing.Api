namespace RideHailing.Contracts.Responses.Auth
{
    public class RegisterUserResponse
    {
        public Guid UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Message { get; set; } = "Registration successful";
    }
}
