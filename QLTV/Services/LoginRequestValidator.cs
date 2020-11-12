using FluentValidation;


namespace QLTV.Services
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(us => us.UserName).NotEmpty().WithMessage("Bạn chưa nhập tên đăng nhập");
            RuleFor(us => us.Password).NotEmpty().WithMessage("Bạn chưa nhập mật khẩu")
                .MinimumLength(6).WithMessage("Mật khẩu phải có ít nhất 6 ký tự");
        }
    }
}
