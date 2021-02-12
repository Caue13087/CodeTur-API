using CodeTur.Comum.Enum;
using CodeTur.Dominio.Entidades;
using Xunit;

namespace CodeTur.Testes.Entidades
{
    public class UsuarioTestes
    {
        [Fact]
        public void DeveRetornarErroSeUsuarioInvalido()
        {
            var usuario = new Usuario("", "caue.sacchitiello@gmail.com", "123456", EnTipoUsuario.Comum);
            //Espera que o usuário seja invalido
            Assert.True(usuario.Invalid, "Usuário é válido");
        }

        [Fact]
        public void DeveRetornarErroSeEmailInvalido()
        {
            var usuario = new Usuario("", "caue.sacchitiello@gmail.com", "123456", EnTipoUsuario.Comum);
            //Espera que o usuário seja invalido
            Assert.True(usuario.Invalid, "Usuário é válido");
        }

        [Fact]
        public void DeveRetornarSucessoSeUsuarioInvalido()
        {
            var usuario = new Usuario("Cauê Sacchitiello", "caue.sacchitiello@gmail.com", "123456", EnTipoUsuario.Comum);
            usuario.AlterarUsuario("", "emailemail.com");

            //Espera que o usuário seja invalido
            Assert.True(usuario.Invalid, "Usuário é inválido");
        }

        [Fact]
        public void DeveRetornarErroSeTelefoneUsuarioInvalido()
        {
            var usuario = new Usuario("Cauê Sacchitiello", "caue.sacchitiello@gmail.com", "123456", EnTipoUsuario.Comum);
            usuario.AdicionarTelefone("959595");

            //Espera que o usuário seja invalido
            Assert.True(usuario.Invalid, "Telefone é válido");
        }

        [Fact]
        public void DeveRetornarSucessoSeTelefoneUsuarioInvalido()
        {
            var usuario = new Usuario("Cauê Sacchitiello", "caue.sacchitiello@gmail.com", "123456", EnTipoUsuario.Comum);
            usuario.AdicionarTelefone("11987546532");


            //Espera que o usuário seja invalido
            Assert.True(usuario.Valid, "Telefone é inválido");
        }
    }
}