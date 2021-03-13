namespace Template.Core.Problems {
    public class LoginAlreadyUsedException : BadRequestAlertException {
        public LoginAlreadyUsedException() : base(ErrorConstants.EmailAlreadyUsedType, "Login name is already in use!",
            "userManagement", Enums.Enums.ErroreCode.NONE)
        {
        }
    }
}
