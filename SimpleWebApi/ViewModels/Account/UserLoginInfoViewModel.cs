namespace SimpleWebApi.ViewModels.Account
{
    // Models returned by AccountController actions.

    public class UserLoginInfoViewModel
    {
        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }
    }
}
