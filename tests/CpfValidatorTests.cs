using Xunit;

public class CpfValidatorTests
{
    [Fact]
    public void CpfValido_DeveRetornarTrue()
    {
        string cpf = "52998224725";
        Assert.True(CpfValidator.IsValid(cpf));
    }

    [Fact]
    public void CpfInvalido_DeveRetornarFalse()
    {
        string cpf = "12345678900";
        Assert.False(CpfValidator.IsValid(cpf));
    }

    [Fact]
    public void CpfComLetras_DeveRetornarFalse()
    {
        string cpf = "abc98224725";
        Assert.False(CpfValidator.IsValid(cpf));
    }

    [Fact]
    public void CpfComMenosDe11Digitos_DeveRetornarFalse()
    {
        string cpf = "12345678";
        Assert.False(CpfValidator.IsValid(cpf));
    }

    [Fact]
    public void CpfComTodosDigitosIguais_DeveRetornarFalse()
    {
        string cpf = "11111111111";
        Assert.False(CpfValidator.IsValid(cpf));
    }
}
