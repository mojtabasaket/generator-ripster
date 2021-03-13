namespace Template.Core.Problems {
    public class EmailAlreadyUsedException : BadRequestAlertException {
        public EmailAlreadyUsedException() : base(ErrorConstants.EmailAlreadyUsedType, "Email is already in use!",
            "userManagement", Enums.Enums.ErroreCode.NONE)
        {
        }
    }
}
